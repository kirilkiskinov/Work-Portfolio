//Write a program to read an integer n and print all triples of the first n small Latin letters,
//ordered alphabetically.

using System;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        char first = (char) (i + 97);
                        char second = (char) (j + 97);
                        char third = (char) (k + 97);

                        Console.WriteLine($"{first}{second}{third}");
                    }
                }
            }
        }
    }
}
