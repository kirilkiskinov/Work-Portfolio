//You task is to calculate the total price of a purchase from a vending machine.Until you receive “Start” you will 
//be given different coins that are being inserted in the machine. You have to sum them in order to have the total 
//money inserted.There is a problem though.Your vending machine only works with 0.1, 0.2, 0.5, 1, and 2 coins.
//If someone tries to insert some other coins you have to display “Cannot accept { money}” and not add it to the 
//total money.On the next few lines until you receive “End” you will be given products to purchase.Your machine has
//however only “Nuts”, “Water”, “Crisps”, “Soda”, “Coke”. The prices are: 2.0, 0.7, 1.5, 0.8, 1.0 respectively.
//If the person tries to purchase a not existing product print “Invalid product”. Be careful that the person may 
//try to purchase a product they don’t have the money for. In that case print “Sorry, not enough money”. 
//If the person purchases a product successfully print “Purchased { product name}”. After the “End” command print 
//the money that are left formatted to the second decimal point in the format “Change: {money left}”.

using System;

namespace _7._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            double totalSum = 0;

            while (command != "Start")
            {
                double currentAmount = double.Parse(command);

                if (currentAmount != 0.1 && currentAmount != 0.2 && currentAmount != 0.5 && currentAmount != 1 
                    && currentAmount != 2)
                {
                    Console.WriteLine($"Cannot accept {currentAmount}");
                }
                else
                {
                    totalSum += currentAmount;
                }
               
                command = Console.ReadLine();
            }

            string item = Console.ReadLine();

            while (item != "End")
            {
                double currentPrice = 0;
                switch (item)
                {
                    case "Nuts": currentPrice = 2.0; break;
                    case "Water": currentPrice = 0.7; break;
                    case "Crisps": currentPrice = 1.5; break;
                    case "Soda": currentPrice = 0.8; break;
                    case "Coke": currentPrice = 1.0; break;

                    default: Console.WriteLine("Invalid product");
                        item = Console.ReadLine();
                        continue;
                }

                if (totalSum >= currentPrice)
                {
                    totalSum -= currentPrice;                    
                    Console.WriteLine($"Purchased {item.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }

                item = Console.ReadLine();
            }

            Console.WriteLine($"Change: {totalSum:F2}");

        }
    }
}
