//Read two arrays and print on the console whether they are identical or not. Arrays are 
//identical if their elements are equal. If the arrays are identical find the sum of the 
//first one and print on the console following message: "Arrays are identical. Sum: {sum}", 
//otherwise find the first index where the arrays differ and print on the console following 
//message: "Arrays are not identical. Found difference at {index} index".

using System;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // read the first array;
            string input1 = Console.ReadLine();

            string[] array1 = input1.Split();

            int[] numbers1 = new int[array1.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                numbers1[i] = int.Parse(array1[i]);
            }

            // read the second array;

            string input2 = Console.ReadLine();

            string[] array2 = input2.Split();

            int[] numbers2 = new int[array2.Length];

            for (int i = 0; i < array2.Length; i++)
            {
                numbers2[i] = int.Parse(array2[i]);
            }

            int sum = 0;

            for (int i = 0; i < numbers1.Length; i++)
            {
                if (numbers1[i] != numbers2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
                else
                {
                    sum += numbers1[i];

                    if (i == numbers1.Length - 1)
                    {
                        Console.WriteLine($"Arrays are identical. Sum: {sum}");
                        break;
                    }
                }
            }
        }
    }
}
