//Read an array of strings (space separated values), reverse it and print its elements.

using System;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] array = input.Split();

            for (int i = 0; i < array.Length / 2; i++)
            {
                string temp = array[i];
                array[i] = array[array.Length - 1 -i];
                array[array.Length - 1 - i] = temp;                
            }

            //using for cycle
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i] + " ");
            //}

            //using string.Join Method
            //Console.WriteLine(string.Join(" ",array));

            foreach (string element in array)
            {
                Console.Write(element + " ");
            }
        }
    }
}
