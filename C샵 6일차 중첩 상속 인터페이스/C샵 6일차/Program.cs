using System;

namespace C샵_6일차
{
    interface ILogger
    {
        void WriteLog(string message);
    }
    interface IFormattableLogger : ILogger
    {
        void WriteLog(string format, params Object[] args);
    }

    class ConsoleLogger2 : IFormattableLogger
    {
        
        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToLocalTime()},{message}");
        }
        public void WriteLog(string format, params Object[] args)
        {
            String message = String.Format(format, args);
            Console.WriteLine($"{DateTime.Now.ToLocalTime()},{message}");

        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            ConsoleLogger2 logger = new ConsoleLogger2();
            //IFormattableLogger logger = new ConsoleLogger2();
            logger.WriteLog("The world is not flat");
            logger.WriteLog("{0} + {1} = {2}", 1, 1, 2);
        }
    }
}
