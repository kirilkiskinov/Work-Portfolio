//Create a program that multiplies the sum of all even digits of a number by the sum of all 
//odd digits of the same number:
//•	Create a method called GetMultipleOfEvenAndOdds()
//•	Create a method GetSumOfEvenDigits()
//•	Create GetSumOfOddDigits()
//•	You may need to use Math.Abs() for negative numbers

using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            int evenDigitsSum = GetSumOfEvenDigits(number);
            int oddDigitsSum = GetSumOfOddDigits(number);

            int multiplication = GetMultipleOfEvenAndOdds(evenDigitsSum, oddDigitsSum);

            Console.WriteLine(multiplication);
        }

        static int GetSumOfEvenDigits(int num)
        {
            int sum = 0;

            while (num > 0)
            {
                int current = num % 10;

                if (current % 2 == 0)
                {
                    sum += current;
                }

                num = num / 10;
            }

            return sum;
        }

        static int GetSumOfOddDigits(int num)
        {
            int sum = 0;

            while (num > 0)
            {
                int current = num % 10;

                if (current % 2 != 0)
                {
                    sum += current;
                }

                num = num / 10;
            }

            return sum;
        }

        static int GetMultipleOfEvenAndOdds(int oddDigitsSum, int evenDigitsSum)
        {
            return oddDigitsSum * evenDigitsSum;
        }

    }
}
