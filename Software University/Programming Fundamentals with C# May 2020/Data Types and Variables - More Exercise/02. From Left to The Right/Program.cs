//You will receive number which represent how many lines we will get as an input. 
//On the next N lines, you will receive a string with 2 numbers separated by single space. 
//You need to compare them. If the left number is greater than the right number, you need to 
//print the sum of all digits in the left number, otherwise print the sum of all digits in 
//the right number.

using System;

namespace _02._From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string words = Console.ReadLine();                

                string[] numbers = words.Split(); //used to break a delimited string into substrings;

                string firstNumber = numbers[0];
                string secondNumber = numbers[1];

                long leftNumber = Convert.ToInt64(firstNumber); //convert string to long
                long rightNumber = Convert.ToInt64(secondNumber); //convert string to long                

                if (leftNumber > rightNumber)
                {
                    long sumDigitsLeft = 0;

                    while (leftNumber != 0)
                    {                        
                        sumDigitsLeft += leftNumber % 10;
                        leftNumber /= 10;
                    }

                    Console.WriteLine(Math.Abs(sumDigitsLeft));
                }
                else                              
                {
                    long sumDigitsRight = 0;

                    while (rightNumber != 0)
                    {
                        sumDigitsRight += rightNumber % 10;
                        rightNumber /= 10;
                    }

                    Console.WriteLine(Math.Abs(sumDigitsRight));
                }
            }
        }
    }
}
