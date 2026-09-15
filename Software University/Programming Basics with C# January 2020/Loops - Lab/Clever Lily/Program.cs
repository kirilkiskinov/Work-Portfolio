using System;

namespace Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int toys = 0;
            int Money = 0;
            int savedMoney = 0;
            int stolenMoney = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    Money = Money + 10;

                    savedMoney += Money; 

                    stolenMoney += 1; 

                }
                else
                {
                    toys++;
                }
            }

            int toysMoney = toys * toyPrice;

            int moneyLeft = savedMoney + toysMoney - stolenMoney;

            if (moneyLeft >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {moneyLeft - washingMachinePrice:F2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMachinePrice - moneyLeft:F2}");
            }
        }
    }
}
