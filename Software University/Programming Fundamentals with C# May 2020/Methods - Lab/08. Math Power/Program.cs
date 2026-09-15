//Create a method that calculates and returns the value of a number raised to a given power.

using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine($"{CalculatePowerOfNumber(number, power)}");
        }

        static double CalculatePowerOfNumber(double num, int pow)
        {
            double powerOfNumber = Math.Pow(num, pow);

            return powerOfNumber;
        }
    }
}
