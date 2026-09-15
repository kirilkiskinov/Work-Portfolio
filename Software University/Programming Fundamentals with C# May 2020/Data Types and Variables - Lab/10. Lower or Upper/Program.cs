//Write a program that prints whether a given character is upper-case or lower case.

using System;

namespace _10._Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());

            //if (input >= 'a' && input <= 'z')
            //{
            //    Console.WriteLine("lower-case");
            //}
            //else
            //{
            //    Console.WriteLine("upper-case");
            //}

            if (Char.IsUpper(input))
            {
                Console.WriteLine("upper-case");
            }
            else if (Char.IsLower(input))
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
