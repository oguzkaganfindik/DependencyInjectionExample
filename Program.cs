using DependencyInjectionExample.Concretes;
using DependencyInjectionExample.ConcretesHatasiz;

namespace DependencyInjectionExample
{
    public class Program
    {
        static void Main(string[] args)
       {
            //Processor processor = new Processor();
            //processor.Process();

            FileLogger2 fileLogger = new FileLogger2();
            SmsSender2 smsSender = new SmsSender2();

            Processor2 processor = new Processor2(fileLogger, smsSender);
            processor.Process();
        }
    }
}