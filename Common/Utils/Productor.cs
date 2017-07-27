using System;
using System.Text;
using RabbitMQ.Client;
using System.Diagnostics;
using Common.Model;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Common;

namespace Common.Utils
{
    public class Productor
    {
        public static void SentMessage(EnumTransferType type,string exchangeName,string routingKey,MessageModel msg)
        {
            
            var factory = new ConnectionFactory();
            //サーバー名
            factory.HostName = "godpubtest";
            //RabbitServerのユーザー名
            factory.UserName = "chiyoda";
            //RabbitServerのパスワード
            factory.Password = "chiyoda";

            try
            {
                using (var connection = factory.CreateConnection())
                {
                    using (var channel = connection.CreateModel())
                    {

                        var body = SerializeTool.GetArray(msg);

                        var properties = channel.CreateBasicProperties();
                        properties.Persistent = true;

                        switch (type){
                            case EnumTransferType.All:
                                channel.ExchangeDeclare(exchange: exchangeName, type: "fanout",durable:true);

                                //------Persistent----------------------------------
                                channel.BasicPublish(
                                    exchange: exchangeName,
                                    routingKey: routingKey,
                                    basicProperties: properties,
                                    body: body);

                                break;
                            case EnumTransferType.Dept:
                                channel.ExchangeDeclare(exchange: exchangeName, type: "topic",durable:true);

                                //------Persistent----------------------------------
                                channel.BasicPublish(
                                    exchange: exchangeName,
                                    routingKey: routingKey,
                                    basicProperties: properties,
                                    body: body);

                                break;
                            default:
                                //------Persistent----------------------------------
                                channel.BasicPublish(
                                    exchange: "",
                                    routingKey: routingKey,
                                    basicProperties: properties,
                                    body: body);
                                break;
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