using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C샵_대리자
{
    delegate int MyDelegate(int a, int b);

    class Calculator
    {
        public int Plus(int a,int b)
        {
            return a + b;
        }
        public int Minus(int a, int b)
        {
            return a - b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator Calc = new Calculator();
            MyDelegate Callback;
            Callback = new MyDelegate(Calc.Plus);
            Console.WriteLine(Callback(3, 4));

            Callback = new MyDelegate(Calc.Minus);
            Console.WriteLine(Callback(3, 4));
        }
    }
}
