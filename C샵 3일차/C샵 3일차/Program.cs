using System;
using static System.Console;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C샵_3일차
{
    class Program
    {
        static void Main(string[] args)
        {
            string result1 = string.Format("ABC{0, 10}GHI", "DEF");
            string result2 = string.Format("ABC{0, -10}GHI", "DEF");
            WriteLine(result1);
            WriteLine(result2);

            string fmt = "{0, -20}{1,-15}{2,30}";
            WriteLine(fmt, "Publisher", "Author", "Title");
            WriteLine(fmt, "Marvel", "Stan Lee", "Iron Man");
            WriteLine(fmt, "Hanbit", "Sanghyun Park", "C# 7.0 Programming");
            WriteLine(fmt, "Prentice Hall", "K&R", "The C Programming Language");

            WriteLine("10진수 : {0:D}", 123);
            WriteLine("10진수 : {0:D5}", 123);
            WriteLine("16진수 : {0:X}", 0xFF1234);
            WriteLine("16진수 : {0:X8}", 0xFF1234);
            WriteLine("숫자 : {0:N}", 123456789);
            WriteLine("숫자 : {0:N0} ",123456789);
            WriteLine("고정소수점 : {0:F}", 123.45);
            WriteLine("고정소수점 : {0:F5}", 123.45);
            WriteLine("공학: {0:E}", 123.456789);

            DateTime dt = new DateTime(2020, 8, 12, 11, 4, 22);
            WriteLine("12시간 : {0:yyyy-MM-dd tt HH:mm:ss (ddd)}", dt);
            WriteLine("24시간 : {0:yyyy-MM-dd HH:mm:ss (dddd)}",dt);

            CultureInfo ciKo = new CultureInfo("ko-KR");
            WriteLine();
            WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciKo));

            int number = 30210;
            string name = "유원형";
            WriteLine($"{number:D}, {name, 10}");// WriteLine("{0:D}, {1,10}",number,name); 이것보다 간편하고 쓰기 위움


        }
    }
}
