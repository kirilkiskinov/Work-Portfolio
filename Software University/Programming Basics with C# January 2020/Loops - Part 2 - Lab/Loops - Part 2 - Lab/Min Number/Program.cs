using System;

namespace Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int minNumber = int.MaxValue;

            int counter = 1;

            while (counter <= n)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber < minNumber)
                {
                    minNumber = currentNumber;
                }

                counter++;
            }

            Console.WriteLine(minNumber);

        }
    }
}
