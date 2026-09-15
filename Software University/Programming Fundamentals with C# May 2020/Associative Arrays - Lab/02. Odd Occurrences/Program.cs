//Write a program that extracts all elements from a given sequence of words that are present 
//in it an odd number of times (case-insensitive).
//•	Words are given on a single line, space separated.
//•	Print the result elements in lowercase, in their order of appearance.

using System;
using System.Collections.Generic;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Dictionary<string, int> occurrences = new Dictionary<string, int>();

            foreach (var occurrence in input)
            {
                string current = occurrence.ToLower();

                if (occurrences.ContainsKey(current))
                {
                    occurrences[current]++;
                }
                else
                {
                    occurrences.Add(current, 1);
                }
            }

            foreach (var item in occurrences)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write($"{item.Key} ");
                }
            }

        }
    }
}
