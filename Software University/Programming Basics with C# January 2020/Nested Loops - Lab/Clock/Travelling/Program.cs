using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double savedMoney = 0;           

            while (input != "End")
            {
                double budget = double.Parse(Console.ReadLine());                

                while (savedMoney < budget)
                {
                   double money = double.Parse(Console.ReadLine());                    
                  
                    savedMoney += money;

                    if (savedMoney >= budget)
                    {
                        Console.WriteLine($"Going to {input}!");                      

                        savedMoney = 0;

                        break;
                    }
                }

                input = Console.ReadLine();

            }
        }
    }
}
