//Write a method that receives a single integer N and prints NxN matrix with that number.

using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintNxNMattix(number);
        }

        static void PrintNxNMattix(int num)
        {
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    Console.Write(num + " ");
                }

                Console.WriteLine();
            }           
        }

    }
}
