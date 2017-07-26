using Common.Utils;
using Common.Model;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RabbitMQSubscribeDemo
{
    delegate bool AddNewMessage(MessageModel msg);
    public partial class Subscriber : Form
    {
        private bool isListening = false;
        public Subscriber()
        {
            InitializeComponent();
        }

        private void btnReceiveMsgStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text) && string.IsNullOrEmpty(txtDept.Text))
            {
                MessageBox.Show("部署と担当者がいずれか入力してください！");
                return;
            }

            tsStatusLable.Text = "受信中";
            tsStatusLable.BackColor = Color.Green;

            btnReceiveMsgStart.Enabled = false;
            btnRecevieMsgStop.Enabled = true;

            isListening = true;
            //受信処理起動
            bgwConsume.RunWorkerAsync(new AddNewMessage(MessageReceivedHandle));
        }

        private void btnRecevieMsgStop_Click(object sender, EventArgs e)
        {
            //受信処理停止
            tsStatusLable.Text = "受信停止";
            tsStatusLable.BackColor = Color.Red;

            btnReceiveMsgStart.Enabled = true;
            btnRecevieMsgStop.Enabled = false;

            isListening = false;

            if (bgwConsume.IsBusy)
            {
                bgwConsume.CancelAsync();
            }
            bgwConsume.Dispose();
            //try
            //{
            //    receiver.Dispose();
            //} catch (Exception ex)
            //{
            //    Debug.WriteLine("Receiver Stop Error:{0}",ex.Message);
            //}
            //finally
            //{
            //    receiver = null;
            //}

        }

        private bool MessageReceivedHandle(MessageModel msg)
        {
            try
            {

                var index=grdMsgDetils.Rows.Add(msg.MsgID, msg.MsgCreateUser, msg.MsgCreateDateTime, msg.MsgRecOrder, msg.MsgContent);

                //Debug用
                //if (index > 0)
                //{
                //    Console.WriteLine("MessageReceivedHandle Method Excuted:{0}", index);
                //    return true;
                //}
                //else
                //{
                //    Console.WriteLine("MessageReceivedHandle Method Excuted:{0}", false);
                //    return false;
                //}

            }
            catch(Exception ex)
            {
                Debug.WriteLine("Grid Data Setting Error:{0}", ex.Message);
            }
            return false;
        }

        private void bgwConsume_DoWork(object sender, DoWorkEventArgs e)
        {
            Console.WriteLine("bgwConsume_DoWork Done!");
            var factory = new ConnectionFactory();
            //サーバー名
            factory.HostName = "godpubtest";
            //RabbitServerのユーザー名
            factory.UserName = "chiyoda";
            //RabbitServerのパスワード
            factory.Password = "chiyoda";

            var queueName = "task_queue";

            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {

                    //Useage:② Message durability（消息持久机制），关键参数 durable
                    channel.QueueDeclare(queue: queueName,
                                         durable: true /* 如果 生产者 设置为 true，相应的 消费者 也需要设置为 true 才会生效 */,
                                         exclusive: false,
                                         autoDelete: false,
                                         arguments: null);


                    // Fair dispatch（公平触发机制）
                    channel.BasicQos(
                        prefetchSize: 0,
                        prefetchCount: 1,
                        global: false);


                    var consumer = new EventingBasicConsumer(channel);
                    consumer.Received += (ch, ea) =>
                    {

                        var body = SerializeTool.GetBody(ea.Body);

                        IBasicProperties basicProperties = ea.BasicProperties;
                        Console.WriteLine("Message received by the event based consumer. Check the debug window for details.");
                        Debug.WriteLine("------------------------------------------------------------------");
                        Debug.WriteLine(string.Concat("Message received from the exchange ", ea.Exchange));
                        Debug.WriteLine(string.Concat("Content type: ", basicProperties.ContentType));
                        Debug.WriteLine(string.Concat("Consumer tag: ", ea.ConsumerTag));
                        Debug.WriteLine(string.Concat("Delivery tag: ", ea.DeliveryTag));
                        Debug.WriteLine(string.Concat("Message id: ", body.MsgID));
                        Debug.WriteLine(string.Concat("Message: ", body.MsgContent));

                        AddNewMessage a = (AddNewMessage)e.Argument;
                        this.Invoke(a,body);

                        // 如果 channel.BasicConsume 中参数 noAck 设置为 false，必须加上消息确认语句
                        // Message acknowledgment（消息确认机制作用）
                        channel.BasicAck(ea.DeliveryTag, false);
                    };

                    try
                    {
                        string consumeID = channel.BasicConsume(queue: queueName,
                         autoAck: false,/* Message acknowledgment（消息确认机制） */
                         consumer: consumer);

                        Console.WriteLine(" Consume ID={0}", consumeID);

                        while (isListening)
                        {
                            //Console.WriteLine(" Consume status={0}", consumer.IsRunning);
                        }


                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("Consume Register Failure:{0}", ex.Message);
                    }
                }

            }
        }
    }
}
