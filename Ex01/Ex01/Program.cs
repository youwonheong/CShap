using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    class NameCard
    {
        public int Age
        {
            get;
            set;
        }
        public String Name
        {
            get;
            set;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NameCard MyCard = new NameCard()
            {
                Age = 24,
                Name = "상현"
            };

            Console.WriteLine($"나이 : {MyCard.Age}");
            Console.WriteLine($"이름 : {MyCard.Name}");

        }
    }
}
