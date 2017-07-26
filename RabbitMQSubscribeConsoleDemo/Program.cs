using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Utils;


namespace RabbitMQSubscribeConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //SubMessages sub = new SubMessages();
            //SubMessagesWithCallBack.GetMessage();
            Consumer.GetMessage();
            Console.ReadLine();
        }
    }
}
