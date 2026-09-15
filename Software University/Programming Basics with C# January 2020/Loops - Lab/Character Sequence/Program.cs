using System;

namespace Character_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = 0; i <= input.Length - 1; i++)
            {
                char letter = input[i];

                Console.WriteLine(letter);
            }
        }
    }
}
