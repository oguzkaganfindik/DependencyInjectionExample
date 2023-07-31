using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample.Concretes
{
    public class MailSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("MailSender: " + message);
        }
    }
}
