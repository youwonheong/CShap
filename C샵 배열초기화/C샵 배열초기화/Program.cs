using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C샵_배열초기화
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] array1 = new string[3] {  "안녕", "Hello", "Halo" };
            foreach(string getstring in array1)
            {
                Console.Write($"{getstring}");
            }
            Console.WriteLine();
            string[] array2 = new string[] { "안녕","Hello","Halo"};

            foreach (string getstring in array2)
            {
                Console.Write($"{getstring}");
            }
            Console.WriteLine();

            string[] array3 = { "안녕", "Hello", "Halo" };

            foreach (string getstring in array3)
            {
                Console.Write($"{getstring}");
            }
            Console.WriteLine();

        }
    }
}
