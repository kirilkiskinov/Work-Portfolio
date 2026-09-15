//Write a program that calculates the difference between the sum of the even and the sum 
//of the odd numbers in an array.

using System;

namespace _06._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] array = input.Split();

            int[] numbers = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                numbers[i] = int.Parse(array[i]);
            }

            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                
                if (currentNumber % 2 == 0)
                {
                    evenSum += currentNumber;
                }
                else
                {
                    oddSum += currentNumber;
                }
            }

            int difference = evenSum - oddSum;

            Console.WriteLine(difference);
        }
    }
}
