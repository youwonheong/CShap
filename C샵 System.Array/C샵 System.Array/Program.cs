using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace C샵_System.Arra
{
    class Program
    {
        private static bool CheckPassed(int score)
        {
            if (score >= 60) return true;
            else return false;
        }

        private static void Print(int value)
        {
            Console.Write($"{value}");
        }

        static void Main(string[] args)
        {
            int[] score = new int[] { 80, 74, 81, 90, 34 };

            foreach(int scores in score)
            {
                Console.WriteLine($"{scores}");
            }
            Console.WriteLine();

            Array.Sort(score); // 배열을 정렬
            Array.ForEach<int>(score, new Action<int>(Print)); 
            Console.WriteLine();

            Console.WriteLine($"Number of dimensions : {score.Rank}"); // 배열의 차원을 출력


            Console.WriteLine($"Old length of scores : {score.Length}");
            Array.Resize<int>(ref score, 10); //배열의 크기를 재조정
            Console.WriteLine($"New length of socres : {score.Length}");

            Array.Clear(score, 3, 7); 
             Array.ForEach<int>(score, new Action<int>(Print));
        }
    }
}
