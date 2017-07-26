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

    public class SerializeTool
    {

        /// <summary>
        /// メッセージのデシリアライズ処理
        /// </summary>
        /// <param name="body">直列化したメッセージ対象</param>
        /// <returns>メッセージ対象</returns>
        public static   MessageModel GetBody(byte[] body)
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
        /// <summary>
        /// メッセージのシリアライズ処理（直列化）
        /// </summary>
        /// <param name="msg">メッセージ対象</param>
        /// <returns>シリアライズ結果</returns>
        public static byte[] GetArray(Object msg)
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
