using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C샵_일반화_컬렉션
{
    class Program
    {
        
        static void Main(string[] args)
        {
            /* List<int> list = new List<int>();
             for(int i =1; i<6; i++)
             {
                 list.Add(i);
             }
             foreach (int element in list)
                 Console.Write(element+ " ");
             Console.WriteLine(); 
             list.RemoveAt(2);
              
             foreach (int element in list)
                 Console.Write(element + " ");
             Console.WriteLine();

             list.Insert(2, 200);

             foreach (int element in list)
                 Console.Write(element + " ");
             Console.WriteLine();*/ // 리스트<T> 

            /*Queue<int> queue = new Queue<int>();
            for(int i=0; i<5; i++)
            {
                queue.Enqueue(i + 1);
            }
            while (queue.Count > 0)
                Console.WriteLine(queue.Dequeue());*/ // 큐 <T>

            /* Stack<int> stack = new Stack<int>();

             for(int i =0; i < 5; i++)
             {
                 stack.Push(i + 1);
             }
             while (stack.Count > 0)
                 Console.WriteLine(stack.Pop());*/ // 스택 <T>
            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic["하나"] = "one";
            dic["둘"] = "two";
            dic["셋"] = "three";
            dic["넷"] = "four";
            dic["다섯"] = "five";
            Console.WriteLine(dic["하나"]);
            Console.WriteLine(dic["둘"]);
            Console.WriteLine(dic["셋"]);
            Console.WriteLine(dic["넷"]);
            Console.WriteLine(dic["다섯"]);
             

        }
    }
}
