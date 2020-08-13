﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C샵_4일차_객체_복사_
{
    class MyClass
    {
        public int MyField1;
        public int MyField2;

        public MyClass DeepCopy()// 리턴받는 자료형(?)이 MyClass
        {
            MyClass newCopy = new MyClass();
            newCopy.MyField1 = this.MyField1;
            newCopy.MyField2 = this.MyField2;

            return newCopy;
        }

    }

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Shallow Copy");

            {
                MyClass source = new MyClass();
                source.MyField1 = 10;
                source.MyField1 = 20;


                MyClass target = source;
                target.MyField2 = 30;

                Console.WriteLine($"{source.MyField1},{source.MyField2}");
                Console.WriteLine($"{target.MyField1},{target.MyField2}");

                Console.WriteLine("Shallow Copy");
            }

            Console.WriteLine("Deep Copy");

            {
                MyClass source = new MyClass();
                source.MyField1 = 10;
                source.MyField1 = 20;

                MyClass target = source.DeepCopy();
                target.MyField2 = 30;

                Console.WriteLine($"{source.MyField1},{source.MyField2}");
                Console.WriteLine($"{target.MyField1},{target.MyField2}");

            }
            


        }
    }
}
