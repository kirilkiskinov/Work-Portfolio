//Write a method that receives a single string and prints the count of the vowels.

using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintVowelsCount(input);
        }
        static void PrintVowelsCount(string word)
        {
            char[] vowels = { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u', };

            int vowelsCount = 0;

            for (int i = 0; i < word.Length; i++)
            {
                string substring = word.Substring(i, 1);

                for (int j = 0; j < vowels.Length; j++)
                {
                    if (substring.Contains(vowels[j]))
                    {
                        vowelsCount++;
                    }                   
                }                
            }

            Console.WriteLine(vowelsCount);
        }

    }
}
