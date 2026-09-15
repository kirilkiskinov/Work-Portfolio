using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int currNum = 1; currNum <= number; currNum++)
            {
                int digitsSum = Math.Abs(SumOfDigits(currNum));

                bool containsOddDigit = HoldsAtLeastOneOddDigit(currNum);

                if (digitsSum % 8 == 0 && containsOddDigit == true)
                {
                    Console.WriteLine(currNum);
                }
            }            
            
        }
        static int SumOfDigits(int num)
        {
            int sum = 0;
                        
            while (num != 0)
            {
                sum += num % 10;               

                num /= 10;
            }

            return sum;
        }

        static bool HoldsAtLeastOneOddDigit(int num)
        {
            bool isOddDigit = false;           

            while (num != 0)
            {
                int currentDigit = num % 10;

                if (currentDigit % 2 != 0)
                {
                    isOddDigit = true;
                    break;
                }

                num /= 10;
            }

            return isOddDigit;
        }

    }
}
