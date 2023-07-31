using DependencyInjectionExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample.ConcretesHatasiz
{
    public class SmsSender2 : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("SMSSender : " + message );
        }
    }
}
