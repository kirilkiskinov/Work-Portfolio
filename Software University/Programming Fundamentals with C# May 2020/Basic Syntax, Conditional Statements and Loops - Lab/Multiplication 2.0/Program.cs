//Rewrite you program so it can receive the multiplier from the console. 
//Print the table from the given multiplier to 10. 
//If the given multiplier is more than 10 - print only one row with the integer, the given multiplier and the product.
//See the examples below for more information.
//Print every row of the table in the following format:
//{theInteger} X {times} = {product}

using System;

namespace Multiplication_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());           

            do
            {
                Console.WriteLine($"{number} X {multiplier} = {number * multiplier}");
                multiplier++;

            } while (multiplier <= 10);
        }
    }
}
