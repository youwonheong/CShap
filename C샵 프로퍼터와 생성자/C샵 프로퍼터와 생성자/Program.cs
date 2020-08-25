using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C샵_프로퍼터와_생성자
{
    class Birthdayinfo
    {
        public string Name
        {
            get;
            set;
        }
        public DateTime Birthday
        {
            get;
            set;
        } 
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
            Birthdayinfo birth = new Birthdayinfo()
            {

                Name = "원형",
                Birthday = new DateTime(2002, 12, 30)
            }; 
           
            Console.WriteLine(birth.Name);
            Console.WriteLine(birth.Birthday);
            Console.WriteLine(birth.Age);
        }
    }
}
