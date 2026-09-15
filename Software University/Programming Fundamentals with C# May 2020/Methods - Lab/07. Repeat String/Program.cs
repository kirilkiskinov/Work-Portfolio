//Write a method that receives a string and a repeat count n (integer). 
//The method should return a new string (the old one repeated n times).

using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int repeat = int.Parse(Console.ReadLine());

            Console.WriteLine($"{RepeatString(input, repeat)}");
        }

        static string RepeatString(string input, int repeat)
        {
            string repeatedString = String.Empty;

            for (int i = 0; i < repeat; i++)
            {
                repeatedString += input;
            } 

            return repeatedString;
        }

    }
}
