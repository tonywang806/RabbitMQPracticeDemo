using Common.Utils;
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
    public partial class Subscriber : Form
    {
        SerializeTool receiver = new SerializeTool();
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

            //受信処理起動
            bgwConsume.RunWorkerAsync();
        }

        private void btnRecevieMsgStop_Click(object sender, EventArgs e)
        {
            //受信処理停止
            tsStatusLable.Text = "受信停止";
            tsStatusLable.BackColor = Color.Red;
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

        private void MessageReceivedHandle(Common.Model.MessageModel msg)
        {
            try
            {

                DataGridViewRow row = new DataGridViewRow();
                row.SetValues(msg.MsgID,msg.MsgCreateUser,msg.MsgCreateDateTime,msg.MsgRecOrder,msg.MsgContent);
                grdMsgDetils.Rows.Add(row);

            }
            catch(Exception ex)
            {
                Debug.WriteLine("Grid Data Setting Error:{0}", ex.Message);
            }

        }

        private void bgwConsume_DoWork(object sender, DoWorkEventArgs e)
        {
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
                        //callback(body);

                        // 如果 channel.BasicConsume 中参数 noAck 设置为 false，必须加上消息确认语句
                        // Message acknowledgment（消息确认机制作用）
                        channel.BasicAck(ea.DeliveryTag, false);
                    };

                    try
                    {
                        string consumeID = channel.BasicConsume(queue: queueName,
                         autoAck: false,/* Message acknowledgment（消息确认机制） */
                         consumer: consumer);

                        Console.WriteLine(" Consume ID={0},Consume Status:{1}", consumeID, consumer.IsRunning);

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
