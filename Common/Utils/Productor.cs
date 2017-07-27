using System;
using System.Text;
using RabbitMQ.Client;
using System.Diagnostics;
using Common.Model;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Common.Utils
{
    public class Productor
    {
        public static void SentMessage(MessageModel msg,string routingKey)
        {
            var factory = new ConnectionFactory();
            //サーバー名
            factory.HostName = "godpubtest";
            //RabbitServerのユーザー名
            factory.UserName = "chiyoda";
            //RabbitServerのパスワード
            factory.Password = "chiyoda";

            var exchangeName = "logs";
            var exchangeName_direct = "direct_logs";
            try
            {
                using (var connection = factory.CreateConnection())
                {
                    using (var channel = connection.CreateModel())
                    {

                        var body = SerializeTool.GetArray(msg);

                        //Usage:③ Publish/Subscribe の場合
                        if (string.IsNullOrEmpty(routingKey))
                        {
                            channel.ExchangeDeclare(exchange: exchangeName, type: "fanout");

                            //------Persistent----------------------------------
                            channel.BasicPublish(
                                exchange: exchangeName,
                                routingKey: routingKey,
                                basicProperties: null,
                                body: body);
                        }
                        else
                        {
                            channel.ExchangeDeclare(exchange: exchangeName_direct, type: "direct");

                            //------Persistent----------------------------------
                            channel.BasicPublish(
                                exchange: exchangeName_direct,
                                routingKey: routingKey,
                                basicProperties: null,
                                body: body);
                        }

                        Debug.WriteLine(" set {0}", msg.MsgID);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
       
    }
}