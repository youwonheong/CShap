using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C샵_컬렉션_리스트
{

    class Program
    {
        static void listline(ArrayList list)
        {
            foreach (object obj in list)
                Console.Write($"{obj} ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList(); // int[] array = new array[5]
            for(int i =0; i < 5; i++)
            {
                list.Add(i);
            }
            listline(list);
            

            list.RemoveAt(2);

            listline(list);

            list.Insert(2, 200);
            listline(list);

            list.Add("abc");
            list.Add("def");
            listline(list);
        }
    }
}
