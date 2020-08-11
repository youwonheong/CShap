using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        enum DialogResult { YES=10 ,NO, CANCEL, CONFIRM=50, OK};
        static void Main(string[] args)
        {
            /*sbyte a = 127; Console.WriteLine(a);
            int b = (int)a; Console.WriteLine(b);

            int x = 130; Console.WriteLine(x);
            sbyte y = (sbyte)x; Console.WriteLine(y);*/

            /*float a = 69.6875f; Console.WriteLine("a : {0}",a);
            double b = (double)a; Console.WriteLine("b : {0}",b);

            float x = 0.1f; Console.WriteLine("x : {0}", x);
            double y = (double)x; Console.WriteLine("y : {0}", y);*/

            float a3 = 0.9f; Console.WriteLine("a3 : {0}", a3);
            int b3 = (int)a3; Console.WriteLine("b3 : {0}", b3);

            float c3 = 1.1f; Console.WriteLine("c3 : {0}", c3);
            int d3 = (int)c3; Console.WriteLine("d3 : {0}", d3);

            int a4 = 123;
            string b4  = a3.ToString();
            Console.WriteLine("b4 : {0}", b4);

            float c4 = 3.14f;
            string d4 = c4.ToString();
            Console.WriteLine("d4 : {0}",d4);

            string e4 = "123456";
            int f4 = Convert.ToInt32(e4);
            Console.WriteLine("f4 : {0}", f4);

            string g = "1.2345";
            float h = float.Parse(g);
            Console.WriteLine("h : {0}", h);

            const int MAX_INT = 2147483647;
            const int MIN_INT = -214783648;

            Console.WriteLine((int)DialogResult.YES);
            Console.WriteLine((int)DialogResult.NO);
            Console.WriteLine((int)DialogResult.CANCEL);
            Console.WriteLine((int)DialogResult.CONFIRM);
            Console.WriteLine((int)DialogResult.OK);

            int? a5 = null;
            Console.WriteLine(a5.HasValue);
            Console.WriteLine(a5 != null);
            a5 = 3;
            Console.WriteLine(a5.Value);

            var a6 = 20;
            Console.WriteLine("Type : {0} , Value : {1}", a6.GetType(), a6);
            var b6 = 3.1414213;
            Console.WriteLine("Type : {0} , Value : {1}", b6.GetType(), b6);
            var c6 = "Hello World";
            Console.WriteLine("Type : {0} , Value : {1}", c6.GetType(), c6);
            var d6 = new int[] { 10, 20, 30 };
            Console.WriteLine("Type : {0} , Value : {1}", d6.GetType(), d6[0]);
            foreach(var e in d6)
            {
                Console.WriteLine("Type : {0} , Value : {1}", e.GetType(), e);
            }




        }
    }
}
