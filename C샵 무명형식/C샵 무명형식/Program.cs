using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C샵_무명형식
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new { Name = "원형", Age = 1234 };
            Console.WriteLine($"Name : {a.Name},Age : {a.Age}");

            var b = new { Subject = "C#", Scores = new int[] { 90, 80, 70, 60 } };
            Console.Write($"Subject : {b.Subject}, Score : ");
            foreach(var score in b.Scores)
            {
                Console.Write($"{score} ");
            }
        }
    }
}
