//You will receive a single string. Write a method that prints the middle character. 
//If the length of the string is even there are two middle characters.

using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            PrintMiddleCharacter(str);
        }

        static void PrintMiddleCharacter(string input)
        {
            int middleCharIndex = input.Length / 2;

            char[] characters = input.ToCharArray();

            if (input.Length % 2 == 0)
            {               
                Console.Write(characters[middleCharIndex - 1]);
                Console.Write(characters[middleCharIndex]);
            }
            else
            {                
                Console.Write(characters[middleCharIndex]);
            }

        }
    }
}
