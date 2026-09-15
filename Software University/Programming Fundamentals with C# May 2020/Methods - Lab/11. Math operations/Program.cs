//Write a method that receives two number and an operator, calculates the result and returns 
//it. You will be given three lines of input. The first will be the first number,
//the second one will be the operator and the last one will be the second number. 
//The possible operators are: / * + -
//Print the result rounded up to the second decimal point.

using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            char theOperator = char.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            Console.WriteLine($"{Calculate(first, theOperator, second):F2}");
        }

        static double Calculate(int a, char theOperator, int b)
        {
            double calculation = 0;

            if (theOperator == '+')
            {
                calculation = a + b;
            }
            else if (theOperator == '-')
            {
                calculation = a - b;
            }
            else if (theOperator == '*')
            {
                calculation = a * b;
            }
            else if (theOperator == '/')
            {
                calculation = a * 1.0 / b;
            }

            return calculation;
        }

    }
}
