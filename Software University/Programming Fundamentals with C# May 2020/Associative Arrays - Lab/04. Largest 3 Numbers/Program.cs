//Read a list of integers and print the largest 3 of them. 
//If there are less than 3, print all of them.

using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //First way:

            //List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            //numbers.Sort();

            //numbers.Reverse();

            //if (numbers.Count > 3)
            //{
            //    List<int> largest3 = numbers.GetRange(0, 3);

            //    Console.WriteLine(string.Join(' ', largest3)); 
            //}
            //else
            //{
            //    Console.WriteLine(string.Join(' ', numbers)); 
            //}

            //Second way:

            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderByDescending(n => n)               
                .ToList();

            if (numbers.Count > 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers));
            }

        }
    }
}
