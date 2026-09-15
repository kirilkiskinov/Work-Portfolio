using System;

namespace Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxNumber = int.MinValue;

            int counter = 1;

            while (counter <= n)
            {
               int number = int.Parse(Console.ReadLine());

                if (number > maxNumber)
                {
                    maxNumber = number;
                }

                counter++;
            }

            Console.WriteLine(maxNumber);

        }
    }
}
