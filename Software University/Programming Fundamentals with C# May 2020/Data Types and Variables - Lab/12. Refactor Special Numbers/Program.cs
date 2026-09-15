using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int currentNum = 1; currentNum <= n; currentNum++)
            {
                int number = currentNum;
                int sumOfDigits = 0;

                while (number > 0)
                {
                    sumOfDigits += number % 10;
                    number = number / 10;
                }

                bool isSpecial = false;

                isSpecial = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);

                Console.WriteLine("{0} -> {1}", currentNum, isSpecial);                
            }
        }
    }
}
