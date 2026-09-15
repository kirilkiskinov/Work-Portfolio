//Read two integer numbers. Calculate factorial of each number. Divide the first result by 
//the second and print the division formatted to the second decimal point.

using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            ulong firstFactorial = CalculateFactorial(firstNum);
            ulong secondFactorial = CalculateFactorial(secondNum);

            decimal division = CalculateFactorialDivision(firstFactorial, secondFactorial);

            Console.WriteLine($"{division:F2}");
        }

        static ulong CalculateFactorial(int num)
        {
            ulong factorial = 1;

            for (uint i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
        static decimal CalculateFactorialDivision(ulong a, ulong b)
        {
            return a * 1.0m / b;
        }
    }
}
