using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C샵_자동_구현_프로퍼티
{
    class Birthdayinfo
    {
        public string Name
        {
            get;
            set;
        } = "Unknown";
        public DateTime Birthday
        {
            get;
            set;
        } = new DateTime(2000,1,1);
        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Birthdayinfo birth = new Birthdayinfo();
            Console.WriteLine(birth.Name);
            Console.WriteLine(birth.Birthday);
            Console.WriteLine(birth.Age);
            birth.Name = "원형";
            birth.Birthday = new DateTime(2002, 12, 30);
            Console.WriteLine(birth.Name);
            Console.WriteLine(birth.Birthday);
            Console.WriteLine(birth.Age);
        }
    }
}
