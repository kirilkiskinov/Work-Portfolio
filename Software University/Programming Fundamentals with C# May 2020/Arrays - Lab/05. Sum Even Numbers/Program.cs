//Read an array from the console and sum only the even numbers.

using System;

namespace _05._Sum_Even_Numbers
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

            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }             
            }

            Console.WriteLine(sum);
        }
    }
}
