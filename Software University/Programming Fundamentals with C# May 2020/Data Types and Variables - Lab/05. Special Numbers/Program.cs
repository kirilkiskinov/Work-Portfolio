//A number is special when its sum of digits is 5, 7 or 11. Write a program to read an
//integer n and for all numbers in the range 1…n to print the number and if it is special
//or not(True / False).
//Hints:
//To calculate the sum of digits of given number num, you might repeat the following:
//sum the last digit(num % 10) and remove it(num = num / 10) until num reaches 0.

using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());                     

            for (int currentNumber = 1; currentNumber <= n; currentNumber++)
            {
                int number = currentNumber;                
                int digitsSum = 0;

                while (number > 0)
                {
                    digitsSum += number % 10;
                    number /= 10;                  
                }

                bool isSpecial = false;

                if (digitsSum == 5 || digitsSum == 7 || digitsSum == 11)
                {
                    isSpecial = true;
                }                            

                Console.WriteLine($"{currentNumber} -> {isSpecial}");
            }                      
        }
    }
}
