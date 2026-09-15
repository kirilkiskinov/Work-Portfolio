//Write a program, which takes as an input a grade and prints "Passed!" if the grade is equal or more than 3.00.

using System;

namespace Passed
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
