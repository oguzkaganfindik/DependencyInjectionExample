using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample.Concretes
{
    public class FileLogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("File Logger : " + message);
        }
    }
}
