using DependencyInjectionExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample.ConcretesHatasiz
{
    public class MailSender2 : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("MailSender : " + message);
        }
    }
}
