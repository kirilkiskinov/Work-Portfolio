//Read a list of integers and print them in ascending order, along with their number of 
//occurrences.

using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            SortedDictionary<double, int> occurrences = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (occurrences.ContainsKey(number))
                {
                    occurrences[number]++;
                }
                else
                {
                    occurrences.Add(number, 1);
                }
            }

            foreach (var num in occurrences)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }
        }
    }
}
