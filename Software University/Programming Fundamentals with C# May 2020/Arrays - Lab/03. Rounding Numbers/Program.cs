//Read an array of real numbers (space separated), round them in "away from 0" style and print
//the output as in the example:
//Input:
//0.9 1.5 2.4 2.5 3.14
//Output:
//0.9 => 1
//1.5 => 2
//2.4 => 2
//2.5 => 3
//3.14 => 3

using System;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] array = input.Split();

            double[] numbers = new double[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                numbers[i] = double.Parse(array[i]);
            }

            int[] roundedNumbers = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                roundedNumbers[i] = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);

                if (numbers[i] == -0) // type double can contain -0
                {
                    numbers[i] = 0;
                }

                Console.WriteLine($"{numbers[i]} => {roundedNumbers[i]}");
            }
        }
    }
}
