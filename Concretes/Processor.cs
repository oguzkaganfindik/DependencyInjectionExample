using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample.Concretes
{
    public class Processor
    {
        public void Process()
        {
            //DBLogger logger = new DBLogger();
            FileLogger logger = new FileLogger();
            logger.WriteLog("Log Text");

            //MailSender sender = new MailSender();
            SmsSender sender = new SmsSender();
            sender.SendMessage("Message Text");
        }
    }
}
