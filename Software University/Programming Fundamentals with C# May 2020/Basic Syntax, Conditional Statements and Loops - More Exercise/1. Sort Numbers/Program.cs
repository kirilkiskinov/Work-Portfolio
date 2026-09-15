//Read three real numbers and sort them in descending order. Print each number on a new line.

using System;

namespace _1._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int maxNumber = Math.Max(thirdNumber,(Math.Max(firstNumber,secondNumber)));

            int minNumber = Math.Min(thirdNumber, (Math.Min(firstNumber, secondNumber)));

            int averageNumber = (firstNumber + secondNumber + thirdNumber) - (maxNumber + minNumber);

            Console.WriteLine(maxNumber);
            Console.WriteLine(averageNumber);
            Console.WriteLine(minNumber);            
        }
    }
}
