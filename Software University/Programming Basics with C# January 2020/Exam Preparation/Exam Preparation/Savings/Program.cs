using System;

namespace Savings
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double expenses = double.Parse(Console.ReadLine());

            double casual = income * 0.30;  // income - (income * 0.70);
            double savingsPerMonth = income - (expenses + casual);
            double savedMoney = months * savingsPerMonth;
            double percent = (savingsPerMonth / income) * 100;

            Console.WriteLine($"She can save {percent:F2}%");
            Console.WriteLine($"{savedMoney:F2}");
        }
    }
}

