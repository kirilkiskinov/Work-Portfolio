//Write a program, which helps you buy the games. The valid games are the following games:
//Name      Price
//OutFall 4	$39.99
//CS: OG	$15.99
//Zplinter Zell   $19.99
//Honored 2	$59.99
//RoverWatch	$29.99
//RoverWatch Origins Edition	$39.99
//On the first line, you will receive your current balance – a floating-point number in the
//range[0.00…5000.00]. Until you receive the command “Game Time”, you have to keep buying games.
//When a game is bought, the user’s balance decreases by the price of the game.
//Additionally, the program should obey the following conditions:
//•	If a game the user is trying to buy is not present in the table above, print “Not Found” 
//and read the next line.
//•	If at any point, the user has $0 left, print “Out of money!” and end the program.
//•	Alternatively, if the user is trying to buy a game which they can’t afford, print
//“Too Expensive” and read the next line.
//•	If the game exists and the player has the money for it, print “Bought { nameOfGame}”
//When you receive “Game Time”, print the user’s remaining money and total spent on games,
//rounded to the 2nd decimal place.



using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            double totalMoneySpent = 0;

            while (command != "Game Time")
            {
                if (command == "OutFall 4")
                {
                    if (balance < 39.99)
                    {
                        Console.WriteLine("Too Expensive");                        
                    }
                    else
                    {
                        Console.WriteLine($"Bought {command}");
                        balance -= 39.99;
                        totalMoneySpent += 39.99;
                    }
                }
                else if (command == "CS: OG")
                {
                    if (balance < 15.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine($"Bought {command}");
                        balance -= 15.99;
                        totalMoneySpent += 15.99;
                    }
                }
                else if (command == "Zplinter Zell")
                {
                    if (balance < 19.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine($"Bought {command}");
                        balance -= 19.99;
                        totalMoneySpent += 19.99;
                    }
                }
                else if (command == "Honored 2")
                {
                    if (balance < 59.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine($"Bought {command}");
                        balance -= 59.99;
                        totalMoneySpent += 59.99;
                    }
                }
                else if (command == "RoverWatch")
                {
                    if (balance < 29.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine($"Bought {command}");
                        balance -= 29.99;
                        totalMoneySpent += 29.99;
                    }
                }
                else if (command == "RoverWatch Origins Edition")
                {
                    if (balance < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine($"Bought {command}");
                        balance -= 39.99;
                        totalMoneySpent += 39.99;
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                    command = Console.ReadLine();
                    continue;
                }

                if (balance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Total spent: ${totalMoneySpent:F2}. Remaining: ${balance:F2}");
        }
    }
}
