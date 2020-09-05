using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C샵_throw
{

    class Program
    {
        static void DoSomthing(int arg)
        {
            if (arg < 10)
            {
                Console.WriteLine($"arg : {arg}");
            }
            else
                throw new Exception("arg가 10보다 큽니다.");
        }
        static void Main(string[] args)
        {
            try
            {
                for (int i = 0; i <= 10; i += 2)
                {
                    DoSomthing(i);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
