using System;

namespace Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            char operatorSymbol = char.Parse(Console.ReadLine());

            int result = 0;

            if (operatorSymbol == '+' || operatorSymbol == '-' || operatorSymbol == '*')
            {
                if (operatorSymbol == '+')
                {
                    result = num1 + num2;
                }
                else if (operatorSymbol == '-')
                {
                    result = num1 - num2;
                }
                else if (operatorSymbol == '*')
                {
                    result = num1 * num2;
                }

                string evenOrOdd = "";

                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                }
                else
                {
                    evenOrOdd = "odd";
                }

                Console.WriteLine($"{num1} {operatorSymbol} {num2} = {result} - {evenOrOdd}");
            }
            else if (operatorSymbol == '/')
            {
                if (num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else
                {
                    double resultForDivision = 0;

                    resultForDivision = num1 * 1.0 / num2;

                    Console.WriteLine($"{num1} / {num2} = {resultForDivision:F2}");
                }                
            }
            else if (operatorSymbol == '%')
            {
                if (num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else
                {
                    result = num1 % num2;

                    Console.WriteLine($"{num1} % {num2} = {result}");
                }                
            }            
        }
    }
}
