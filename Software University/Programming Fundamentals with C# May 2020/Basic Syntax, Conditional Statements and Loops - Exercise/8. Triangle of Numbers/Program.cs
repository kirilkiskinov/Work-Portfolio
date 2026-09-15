//Write a program, which receives a number – n, and prints a triangle from 1 to n as in the examples.

using System;

namespace _8._Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int column = 1; column <= row ; column++)
                {
                    Console.Write($"{row} ");                  
                }
                Console.WriteLine();
            }
        }
    }
}
