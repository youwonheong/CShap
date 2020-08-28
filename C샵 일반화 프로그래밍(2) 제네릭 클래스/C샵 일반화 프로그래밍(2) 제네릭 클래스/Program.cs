using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C샵_일반화_프로그래밍_2__제네릭_클래스
{

    class Mylist<T>
    {
        private T[] array;
        public Mylist()
        {
            array = new T[3];
        }

        public T this[int index]
        {
            get { return array[index]; }
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<T>(ref array, index + 1);
                    Console.WriteLine($"Array Resized : {array.Length}");
                }
                array[index] = value;
            }
        }
        public int Length
        {
            get { return array.Length; }
        }
        public int Rank
        {
            get { return array.Rank;  }
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Mylist<string> str_list = new Mylist<string>();
            str_list[0] = "abc";
            str_list[1] = "def";
            str_list[2] = "ghi";
            str_list[3] = "jkl";
            str_list[4] = "mno";

            for(int i=0; i<str_list.Length; i++)
            {
                Console.WriteLine(str_list[i]);
            }
            Console.WriteLine();

            Mylist<int> int_list = new Mylist<int>();
            for(int i = 0; i<5; i++)
            {
                int_list[i] = i; 
            }
            for(int i =0; i< int_list.Length; i++)
            {
                Console.WriteLine(int_list[i]);
            }
            
        }
    }
}
