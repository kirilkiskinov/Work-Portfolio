//A palindrome is a number which reads the same backward as forward, such as 323 or 1001. 
//Write a program which reads a positive integer numbers until you receive "End", 
//for each number print whether the number is palindrome or not.

using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                if (IsPalindrome(input) == true)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }

                input = Console.ReadLine();
            }

        }
        static bool IsPalindrome(string number)
        {
            bool isPalindrome = false;

            int currentIndex = number.Length - 1;

            string reversed = string.Empty;

            while (currentIndex >= 0)
            {
                reversed += number[currentIndex];

                currentIndex--;
            }

            if (String.Compare(number, reversed) == 0)
            {
                isPalindrome = true;
            }

            return isPalindrome;
        }

    }
}
