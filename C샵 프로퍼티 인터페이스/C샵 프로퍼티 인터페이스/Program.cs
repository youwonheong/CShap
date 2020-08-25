using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C샵_프로퍼티_인터페이스
{
    interface INamedValue
    {
        string Name
        {
            get; set; //  구현 안 된 프로퍼티 
        }
        string Value
        {
            get; set;
        }
    }

    class NameValue : INamedValue
    {
        public string Name
        {
            get; // 구현이 된 자동완성 프로퍼티
            set;
        }
        public string Value
        {
            get; set;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            NameValue name = new NameValue() 
            {
                Name = "이름",
                Value = "유원형"
            };
            NameValue height = new NameValue() { Name = "키", Value = "174cm" };
            NameValue weight = new NameValue() { Name = "몸무계", Value = "103kg" };

            Console.WriteLine($"{name.Name} : {name.Value}");
            Console.WriteLine($"{height.Name} : {height.Value}");
            Console.WriteLine($"{weight.Name} : {weight.Value}");

        }
    }
}
