//You will receive an integer as an input from the console. Print the 10 times table for this integer. 
//See the examples below for more information.
//Print every row of the table in the following format:
//{theInteger} X {times} = {product}

using System;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int times = 1;

            while (times <= 10)
            {
                Console.WriteLine($"{number} X {times} = {number * times}");
                times++;
            }
        }
    }
}
