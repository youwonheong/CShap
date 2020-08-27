using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C샵_큐
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue que = new Queue();
            for(int i = 1; i <6; i++)
            {
                que.Enqueue(i);
            }
            while(que.Count > 0)
            {
                Console.WriteLine(que.Dequeue());
            }



        }
    }
}
