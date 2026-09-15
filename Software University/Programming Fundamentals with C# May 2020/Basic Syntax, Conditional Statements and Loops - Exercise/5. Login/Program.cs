//You will be given a string representing a username. The password will be that username reversed. 
//Until you receive the correct password print on the console “Incorrect password. Try again.”. 
//When you receive the correct password print “User {username} logged in.” 
//However on the fourth try if the password is still not correct print “User {username} blocked!” 
//and end the program.

using System;
//using System.Linq;

namespace _5._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            //string username = Console.ReadLine();            

            //string password = new string(username.Reverse().ToArray());

            //string firstUsername = username;

            //for (int i = 1; i <= 4; i++)
            //{
            //    username = Console.ReadLine();

            //    if (username == password)
            //    {
            //        break;
            //    }

            //    if (i == 4)
            //    {
            //        break;
            //    }

            //    Console.WriteLine("Incorrect password. Try again.");

            //}

            //if (username == password)
            //{
            //    Console.WriteLine($"User {firstUsername} logged in.");
            //}
            //else
            //{
            //    Console.WriteLine($"User {firstUsername} blocked!");
            //}

            string username = Console.ReadLine();

            string password = "";

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            string input = Console.ReadLine();
            int counter = 1;

            while (input != password)
            {
                if (counter == 4)
                {
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                input = Console.ReadLine();
                counter++;               
            }

            if (input == password)
            {
                Console.WriteLine($"User {username} logged in.");
            }
            else
            {
                Console.WriteLine($"User {username} blocked!");
            }

        }
    }
}
