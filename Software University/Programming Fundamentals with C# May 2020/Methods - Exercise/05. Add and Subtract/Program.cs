//You will receive 3 integers. Write a method Sum() to get the sum of the first two integers 
//and Subtract() method that subtracts the third integer from the result from the Sum method. 

using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int sum = Sum(firstNum, secondNum);

            int subtraction = Subtract(sum, thirdNum);

            Console.WriteLine(subtraction);
        }
        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }

    }
}
