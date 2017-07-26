using System;
using System.Text;
using RabbitMQ.Client;
using System.Diagnostics;
using Common.Model;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Common.Utils
{
    public class PubMessages
    {
        public static void SentMessage(MessageModel msg)
        {
            var factory = new ConnectionFactory();
            //サーバー名
            factory.HostName = "godpubtest";
            //RabbitServerのユーザー名
            factory.UserName = "chiyoda";
            //RabbitServerのパスワード
            factory.Password = "chiyoda";

            var queueName = "hello";

            try
            {
                using (var connection = factory.CreateConnection())
                {
                    using (var channel = connection.CreateModel())
                    {

                        ////Usage:①簡単の場合
                        //channel.QueueDeclare(
                        //    queue: queueName,
                        //    durable: false,
                        //    exclusive: false,
                        //    autoDelete: false,
                        //    arguments: null
                        //    );
                        //var body = Encoding.UTF8.GetBytes(message);
                        //----------------------------------------

                        //Usage:② Work Queuesの場合
                        queueName = "task_queue";

                        channel.QueueDeclare(
                            queue: queueName,
                            durable: true,
                            exclusive: false,
                            autoDelete: false,
                            arguments: null
                            );
                        //var body = Encoding.UTF8.GetBytes(message);
                        var body = GetArray(msg);

                        // 如果 channel.QueueDeclare 中参数 durable 设置为 true，必须加上持久化语句
                        var properties = channel.CreateBasicProperties();
                        properties.Persistent = true;
                        
                        //----------------------------------------



                        //------Non-Persistent-------------------------------
                        //channel.BasicPublish(
                        //    exchange: "", 
                        //    routingKey: queueName, 
                        //    basicProperties: null, 
                        //    body:body);

                        //------Persistent----------------------------------
                        channel.BasicPublish(
                            exchange: "",
                            routingKey: queueName,
                            basicProperties:properties,
                            body: body);

                        Debug.WriteLine(" set {0}", msg.MsgID);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        /// <summary>
        /// メッセージのシリアライズ処理（直列化）
        /// </summary>
        /// <param name="msg">メッセージ対象</param>
        /// <returns>シリアライズ結果</returns>
        private static byte[] GetArray(Object msg)
        {
            try
            {
                BinaryFormatter b = new BinaryFormatter();
                MemoryStream stream = new MemoryStream();
                b.Serialize(stream, msg);

                return stream.ToArray();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("メッセージのシリアライズが失敗:{0}", ex.Message);
            }

            return null;
        }
    }
}