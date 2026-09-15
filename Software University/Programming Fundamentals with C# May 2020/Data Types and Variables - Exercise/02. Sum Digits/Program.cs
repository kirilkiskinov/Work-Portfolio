//You will be given a single integer. Your task is to find the sum of its digits.

using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int digitsSum = 0;

            while (number != 0)
            {
                digitsSum += number % 10;
                number /= 10;
            }

            Console.WriteLine(digitsSum);
        }
    }
}
