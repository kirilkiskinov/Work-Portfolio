//Write a method to print the smallest of three integer numbers. 

using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            PrintSmallestOfThreeNumbers(firstNum, secondNum, thirdNum);
        }

        static void PrintSmallestOfThreeNumbers(int a, int b, int c)
        {
            int smallest = Math.Min(Math.Min(a, b), c);

            Console.WriteLine(smallest);
        }

    }
}
