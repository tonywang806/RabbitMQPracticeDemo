using System;
using System.Collections.Generic;
using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Diagnostics;
using Common.Model;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Common.Utils
{

    public class SubMessagesWithCallBack : IDisposable
    {

        public delegate void MessageReceivedEvent(MessageModel msg);
        //private IConnection connection;
        //private IModel channel;

        public static void GetMessage(MessageReceivedEvent callback)
        {
            var factory = new ConnectionFactory();
            //サーバー名
            factory.HostName = "godpubtest";
            //RabbitServerのユーザー名
            factory.UserName = "chiyoda";
            //RabbitServerのパスワード
            factory.Password = "chiyoda";

            var queueName = "hello";

            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    ////Useage:① Simple Interaction
                    //channel.QueueDeclare(
                    //    queue: queueName,
                    //    durable: false,
                    //    exclusive: false,
                    //    autoDelete: false,
                    //    arguments: null);
                    //----------------------------------------

                    //Useage:② Message durability（消息持久机制），关键参数 durable
                    queueName = "task_queue";

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
                        //var body = ea.Body;
                        //var message = Encoding.UTF8.GetString(body);
                        //Console.WriteLine(" [x] Received {0}", message);

                        var body=GetBody(ea.Body);

                        IBasicProperties basicProperties = ea.BasicProperties;
                        Console.WriteLine("Message received by the event based consumer. Check the debug window for details.");
                        Debug.WriteLine("------------------------------------------------------------------");
                        Debug.WriteLine(string.Concat("Message received from the exchange ", ea.Exchange));
                        Debug.WriteLine(string.Concat("Content type: ", basicProperties.ContentType));
                        Debug.WriteLine(string.Concat("Consumer tag: ", ea.ConsumerTag));
                        Debug.WriteLine(string.Concat("Delivery tag: ", ea.DeliveryTag));
                        Debug.WriteLine(string.Concat("Message: ", body.MsgID));

                        //callback(body);

                        // 如果 channel.BasicConsume 中参数 noAck 设置为 false，必须加上消息确认语句
                        // Message acknowledgment（消息确认机制作用）
                        channel.BasicAck(ea.DeliveryTag, false);
                    };

                    channel.BasicConsume(queue: queueName,
                                         autoAck: false,/* Message acknowledgment（消息确认机制） */
                                         consumer: consumer);

                    Console.WriteLine(" Press [enter] to exit.");
                    Console.ReadLine();
                    //channel.BasicConsume(queueName, false, eventingBasicConsumer);
                }
            }
        }
        /// <summary>
        /// メッセージのデシリアライズ処理
        /// </summary>
        /// <param name="body">直列化したメッセージ対象</param>
        /// <returns>メッセージ対象</returns>
        private static  MessageModel GetBody(byte[] body)
        {
            try
            {
                BinaryFormatter b = new BinaryFormatter();
                MemoryStream stream = new MemoryStream(body);
                var obj=b.Deserialize(stream);
               
                return (MessageModel)obj;
            }
            catch (Exception ex)
            {
                Console.WriteLine("メッセージのデシリアライズが失敗:{0}", ex.Message);
            }

            return null;
        }

        #region IDisposable Support
        private bool disposedValue = false; // 重複する呼び出しを検出するには

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: マネージ状態を破棄します (マネージ オブジェクト)。
                    //channel.Close();
                    //connection.Close();

                }

                // TODO: アンマネージ リソース (アンマネージ オブジェクト) を解放し、下のファイナライザーをオーバーライドします。
                // TODO: 大きなフィールドを null に設定します。

                disposedValue = true;
            }
        }

        // TODO: 上の Dispose(bool disposing) にアンマネージ リソースを解放するコードが含まれる場合にのみ、ファイナライザーをオーバーライドします。
        // ~SubMessages() {
        //   // このコードを変更しないでください。クリーンアップ コードを上の Dispose(bool disposing) に記述します。
        //   Dispose(false);
        // }

        // このコードは、破棄可能なパターンを正しく実装できるように追加されました。
        public void Dispose()
        {
            // このコードを変更しないでください。クリーンアップ コードを上の Dispose(bool disposing) に記述します。
            Dispose(true);
            // TODO: 上のファイナライザーがオーバーライドされる場合は、次の行のコメントを解除してください。
            // GC.SuppressFinalize(this);
        }
        #endregion


    }
}
