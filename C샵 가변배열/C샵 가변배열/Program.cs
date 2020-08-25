﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C샵_가변배열
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged = new int[3][];
            jagged[0] = new int[5] { 1, 2, 3, 4, 5 };
            jagged[1] = new int[] { 10, 20, 30 };
            jagged[2] = new int[] { 100, 200 };
            

            foreach (int[] arr in jagged)
            {
                Console.WriteLine($"Length : {arr.Length},");
                foreach(int e in arr )
                {
                    Console.Write($"{e} ");
                }
                Console.WriteLine();
            }
        }
    }
}
