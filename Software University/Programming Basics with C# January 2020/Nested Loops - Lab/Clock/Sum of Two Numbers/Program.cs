using System;

namespace Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int combinationsCounter = 0;
            int currentPosition = 0;

            int temp1 = 0;
            int temp2 = 0;
            bool isMagicNumber = false;

            for (int i = startNumber; i <= endNumber; i++)
            {
                for (int j = startNumber; j <= endNumber; j++)
                {
                    combinationsCounter++;                    

                    if (i + j == magicNumber)
                    {
                        currentPosition = combinationsCounter;                        

                        temp1 = i;
                        temp2 = j;
                        isMagicNumber = true;

                        break;
                    }
                }

                if (isMagicNumber == true)
                {                                       
                    break;
                }
            }

            if (isMagicNumber == true)
            {
                Console.WriteLine($"Combination N:{currentPosition} ({temp1} + {temp2} = {magicNumber})");
            }
            else
            {
                Console.WriteLine($"{combinationsCounter} combinations - neither equals {magicNumber}");
            }                          
        }
    }
}
