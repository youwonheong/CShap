using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C샵_try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(arr[i]/i);

                }
            }
            catch(IndexOutOfRangeException e) 
            {
                Console.WriteLine($"예외 발생 : {e.Message}");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"예외 발생 : {e.Message}");
            }
        }
    }
}
