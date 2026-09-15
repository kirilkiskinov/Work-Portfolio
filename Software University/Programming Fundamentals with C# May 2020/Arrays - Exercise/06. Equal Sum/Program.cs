//Write a program that determines if there exists an element in the array such that the sum 
//of the elements on its left is equal to the sum of the elements on its right
//(there will never be more than 1 element like that). If there are no elements to the left 
//or right, their sum is considered to be 0. 
//Print the index that satisfies the required condition or "no" if there is no such index.

using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray(); // 1 2 3 3

            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftSum += numbers[j];
                }

                for (int k = i + 1; k < numbers.Length; k++)
                {
                    rightSum += numbers[k];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine("no");
        }
    }
}
