//Write a program to sum all adjacent equal numbers in a list of decimal numbers,
//starting from left to right.
//After two numbers are summed, the obtained result could be equal to some of its neighbors
//and should be summed as well.
//Always sum the leftmost two equal neighbors(if several couples of equal neighbors are 
//available).

using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] += numbers[i + 1];

                    numbers.RemoveAt(i + 1);

                    i = -1;
                }
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
