//Write a program which reverses a string and print it on the console.

using System;

namespace _4._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string inputReversed = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                inputReversed += input[i];
            }

            Console.WriteLine(inputReversed);
        }
    }
}
