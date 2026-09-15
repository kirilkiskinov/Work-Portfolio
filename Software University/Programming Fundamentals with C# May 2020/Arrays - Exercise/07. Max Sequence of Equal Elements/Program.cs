//Write a program that finds the longest sequence of equal elements in an array of integers. 
//If several longest sequences exist, print the leftmost one.

using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            //my own solution:

            //int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //int count = 1;
            //int longestCount = 1;
            //int longestIndexEnd = 0;

            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] != numbers[i - 1])
            //    {
            //        count = 0;
            //    }

            //    count++;

            //    if (count > longestCount)
            //    {
            //        longestCount = count;
            //        longestIndexEnd = i;
            //    }
            //}

            //for (int i = longestIndexEnd; i > longestIndexEnd - longestCount; i--)
            //{
            //    Console.Write(numbers[i] + " ");
            //}

            //Softuni solution:

            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxLength = 1;
            int length = 1;

            int start = 0;
            int bestStart = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    length++;
                }
                else
                {
                    length = 1;
                    start = i;
                }

                if (length > maxLength)
                {
                    maxLength = length;
                    bestStart = start;
                }
            }

            for (int i = bestStart; i < bestStart + maxLength; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
