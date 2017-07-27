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
            if (string.IsNullOrEmpty(txtUser.Text) && string.IsNullOrEmpty(cmbDept.Text))
            {
                MessageBox.Show("部署と担当者がいずれか入力してください！");
                return;
            }

            tsStatusLableText.Text = "受信中";
            tsStatusLable.BackColor = Color.Green;

            cmbDept.Enabled = false;
            txtUser.Enabled = false;

            btnReceiveMsgStart.Enabled = false;
            btnRecevieMsgStop.Enabled = true;


            tmReceiveFlashLight.Start();

            isListening = true;            
            //受信処理起動
            bgwConsume.RunWorkerAsync(new object[] { cmbDept.Text,new AddNewMessage(MessageReceivedHandle) });
        }

        private void btnRecevieMsgStop_Click(object sender, EventArgs e)
        {
            //受信処理停止
            tsStatusLableText.Text = "受信停止";
            tsStatusLable.BackColor = Color.Red;


            cmbDept.Enabled = true;
            txtUser.Enabled = true;

            btnReceiveMsgStart.Enabled = true;
            btnRecevieMsgStop.Enabled = false;

            tmReceiveFlashLight.Stop();

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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">[0]queue name ; [1] callback method</param>
        private void bgwConsume_DoWork(object sender, DoWorkEventArgs e)
        {
            Console.WriteLine("bgwConsume_DoWork Done!");
            object[] param = (object[])e.Argument;

            var factory = new ConnectionFactory();
            //サーバー名
            factory.HostName = "godpubtest";
            //RabbitServerのユーザー名
            factory.UserName = "chiyoda";
            //RabbitServerのパスワード
            factory.Password = "chiyoda";

            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    //Useage:③　
                    //channel.ExchangeDeclare(exchange: exchangeName, type: "fanout");

                    // Temporary queues
                    var queueName = (string)param[0];

                    // Bindings
                    channel.QueueDeclare(queue: queueName,
                                      durable: true,
                                      exclusive: false,
                                      autoDelete: false,
                                      arguments:null);

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

                        AddNewMessage a = (AddNewMessage)param[1];
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

        private void Subscriber_FormClosing(object sender, FormClosingEventArgs e)
        {
            isListening = false;

            if (bgwConsume.IsBusy)
            {
                bgwConsume.CancelAsync();
            }
            bgwConsume.Dispose();
        }

        private void tmReceiveFlashLight_Tick(object sender, EventArgs e)
        {
            if(this.tsStatusLable.BackColor==Color.Green)
            {
                this.tsStatusLable.BackColor = SystemColors.Control;
            }
            else
            {
                this.tsStatusLable.BackColor = Color.Green;
            }

        }
    }
}
