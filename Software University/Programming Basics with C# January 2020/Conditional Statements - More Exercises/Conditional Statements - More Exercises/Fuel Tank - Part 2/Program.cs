using System;

namespace Fuel_Tank___Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double fuel = double.Parse(Console.ReadLine());
            string clubCard = Console.ReadLine();

            if (fuelType == "Gas")
            {
                if (clubCard == "Yes")
                {
                    double sumWithoutDiscount = fuel * 0.85;

                    if (fuel >= 20 && fuel <= 25)
                    {
                        double sumWithDiscount = sumWithoutDiscount * 0.92;

                        Console.WriteLine($"{sumWithDiscount:F2} lv.");
                    }
                    else if (fuel > 25)
                    {
                        double sumWithDiscount = sumWithoutDiscount * 0.90;

                        Console.WriteLine($"{sumWithDiscount:F2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{sumWithoutDiscount:F2} lv.");
                    }
                }
                else if (clubCard == "No")
                {
                    double sumWithoutDiscount = fuel * 0.93;

                    if (fuel >= 20 && fuel <= 25)
                    {
                        double sumWithDiscount = sumWithoutDiscount * 0.92;

                        Console.WriteLine($"{sumWithDiscount:F2} lv.");
                    }
                    else if (fuel > 25)
                    {
                        double sumWithDiscount = sumWithoutDiscount * 0.90;

                        Console.WriteLine($"{sumWithDiscount:F2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{sumWithoutDiscount:F2} lv.");
                    }
                }
            }
            else if (fuelType == "Gasoline")
            {
                if (clubCard == "Yes")
                {
                    double sumWithoutDiscount = fuel * 2.04;

                    if (fuel >= 20 && fuel <= 25)
                    {
                        double sumWithDiscount = sumWithoutDiscount * 0.92;

                        Console.WriteLine($"{sumWithDiscount:F2} lv.");
                    }
                    else if (fuel > 25)
                    {
                        double sumWithDiscount = sumWithoutDiscount * 0.90;

                        Console.WriteLine($"{sumWithDiscount:F2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{sumWithoutDiscount:F2} lv.");
                    }
                }
                else if (clubCard == "No")
                {
                    double sumWithoutDiscount = fuel * 2.22;

                    if (fuel >= 20 && fuel <= 25)
                    {
                        double sumWithDiscount = sumWithoutDiscount * 0.92;

                        Console.WriteLine($"{sumWithDiscount:F2} lv.");
                    }
                    else if (fuel > 25)
                    {
                        double sumWithDiscount = sumWithoutDiscount * 0.90;

                        Console.WriteLine($"{sumWithDiscount:F2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{sumWithoutDiscount:F2} lv.");
                    }
                }
            }
            else if (fuelType == "Diesel")
            {
                if (clubCard == "Yes")
                {
                    double sumWithoutDiscount = fuel * 2.21;

                    if (fuel >= 20 && fuel <= 25)
                    {
                        double sumWithDiscount = sumWithoutDiscount * 0.92;

                        Console.WriteLine($"{sumWithDiscount:F2} lv.");
                    }
                    else if (fuel > 25)
                    {
                        double sumWithDiscount = sumWithoutDiscount * 0.90;

                        Console.WriteLine($"{sumWithDiscount:F2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{sumWithoutDiscount:F2} lv.");
                    }
                }
                else if (clubCard == "No")
                {
                    double sumWithoutDiscount = fuel * 2.33;

                    if (fuel >= 20 && fuel <= 25)
                    {
                        double sumWithDiscount = sumWithoutDiscount * 0.92;

                        Console.WriteLine($"{sumWithDiscount:F2} lv.");
                    }
                    else if (fuel > 25)
                    {
                        double sumWithDiscount = sumWithoutDiscount * 0.90;

                        Console.WriteLine($"{sumWithDiscount:F2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{sumWithoutDiscount:F2} lv.");
                    }
                }
            }
        }
    }
}
