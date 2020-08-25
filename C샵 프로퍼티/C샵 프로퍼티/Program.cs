using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C샵_프로퍼티
{

     class Birthdayinfo
    {
        private string name;
        private DateTime birthday;
        
        public string Name
        {       
            get { return name; }    //읽기 전용
            set { name = value; }   //쓰기 전용
        }
        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        public int Age
        {
            get { return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;  }

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Birthdayinfo birth = new Birthdayinfo();
            birth.Name = "원형"; // Name의 set
            birth.Birthday = new DateTime(2002, 12, 30); // BirthDay의 set
            //birth.Age = 2020; Age는 읽기 전용 프로퍼티 이기에 값을 수정할 없음

            Console.WriteLine($"Name : {birth.Name}"); //Name의 get
            Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}"); // BirthDay의 get
            Console.WriteLine($"Age : {birth.Age}"); // Age의 get

        }
    }
}
