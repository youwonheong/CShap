using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C샵_베이직스레드
{
    class Program
    {
        static void DoSomething()
        {
            for(int i=0; i < 5; i++)
            {
                Console.WriteLine($"DoSomething {i}");
                Thread.Sleep(10); // 잠깐 CPU점유율을 내려놓는거 10 = 0.01초
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(DoSomething));
            Console.WriteLine("Start thread...");
            t1.Start();
            for(int i =0; i <5; i++)
            {
                Console.WriteLine($"Main : {i}");
                Thread.Sleep(10);
            }
            Console.WriteLine("Waiting until thread Stops...");
            t1.Join();

            Console.WriteLine("Finished");
        }
    }
}
