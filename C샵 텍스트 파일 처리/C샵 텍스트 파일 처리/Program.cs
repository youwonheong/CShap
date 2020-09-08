using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C샵_텍스트_파일_처리
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(new FileStream("a.txt", FileMode.Create));
            sw.Write(int.MaxValue);
            sw.Write("Good Morning");
            sw.Write(uint.MaxValue);
            sw.Write("안녕하세요");
            sw.Write(double.MaxValue);
            sw.Close();

            StreamReader sr = new StreamReader(new FileStream("a.txt", FileMode.Open));
            Console.WriteLine($"File size : {sr.BaseStream.Length}");
            while(sr.EndOfStream == false)
            {
                Console.WriteLine(sr.ReadLine());
                Console.WriteLine();
            }
            sr.Close();
        }
    }
}
