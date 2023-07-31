using DependencyInjectionExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample.ConcretesHatasiz
{
    public class Processor2
    {
        private readonly ILogger _logger;
        private readonly IMessageSender _messageSender;

        public Processor2(ILogger logger, IMessageSender messageSender )
        {
            _logger = logger;
            _messageSender = messageSender;
        }

        public void Process()
        {
            _logger.WriteLog("Log Text");
            _messageSender.SendMessage("Message Text");
        }
    }
}
