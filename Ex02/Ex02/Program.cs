using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameCard = new { Name = "원형", Age = 19 };
            Console.WriteLine($"이름 : {nameCard.Name}, 나이 : {nameCard.Age}");

            var complex = new { Reaㅣ = "리얼", Imaginary = "이매지너리" };
            Console.WriteLine($"Real:{complex.Reaㅣ},Imaginary:{complex.Imaginary}");
        }
    }
}
