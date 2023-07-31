using DependencyInjectionExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample.ConcretesHatasiz
{
    public class DbLogger2 : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("DBLogger : " + message);
        }
    }
}
