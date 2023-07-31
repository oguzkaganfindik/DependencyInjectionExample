using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample.Concretes
{
    public class DBLogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("DbLogger : " + message);
        }
    }
}
