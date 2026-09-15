using System;

namespace Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            int installments = int.Parse(Console.ReadLine());           

            int installmentsCounter = 1;

            double totalSum = 0;

            while (installmentsCounter <= installments)
            {
               double sum = double.Parse(Console.ReadLine());

                if (sum < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    Console.WriteLine($"Total: {totalSum:F2}");
                    return;
                }
                                
                Console.WriteLine($"Increase: {sum:F2}");

                totalSum += sum;
                                             
                installmentsCounter++;                
            }
            
                Console.WriteLine($"Total: {totalSum:F2}");
            
        }
    }
}
