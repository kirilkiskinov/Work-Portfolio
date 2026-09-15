//Write a program to read an array of integers and condense them by summing adjacent couples 
//of elements until a single integer is obtained. For example, if we have 3 elements 
//{2, 10, 3}, we sum the first two and the second two elements and obtain 
//{2+10, 10+3} = {12, 13}, then we sum again all adjacent elements and obtain {12+13} = {25}.

using System;

namespace _08._Condense_Array_to_Number
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

            while (numbers.Length != 1)
            {
                int[] condensed = new int[numbers.Length - 1];

                for (int i = 0; i < condensed.Length; i++)
                {
                    condensed[i] = numbers[i] + numbers[i + 1];
                }

                numbers = condensed;
            }

            Console.WriteLine(numbers[0]);
        }
    }
}
