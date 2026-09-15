//Write a program that reads 3 lines of input. On each line you get a single character.
//Combine all the characters into one string and print it on the console.

using System;

namespace _09._Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());

            string output = first.ToString() + second.ToString() + third.ToString();

            Console.WriteLine(output);
        }
    }
}
