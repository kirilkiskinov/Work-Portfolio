using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine().Split('!').ToList();

            string command = Console.ReadLine();

            while (command != "Go Shopping!")
            {
                string[] tokens = command.Split().ToArray();

                if (tokens[0] == "Urgent")
                {
                    string item = tokens[1];

                    if (groceries.Contains(item))
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        groceries.Insert(0, item);
                    }
                }
                else if (tokens[0] == "Unnecessary")
                {
                    string item = tokens[1];

                    if (groceries.Contains(item))
                    {
                        groceries.Remove(item);
                    }
                    else
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                }
                else if (tokens[0] == "Correct")
                {
                    string oldName = tokens[1];
                    string newName = tokens[2];

                    if (groceries.Contains(oldName))
                    {
                        groceries.Insert(groceries.IndexOf(oldName), newName);
                        groceries.Remove(oldName);                                                
                    }
                    else
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                }
                else if (tokens[0] == "Rearrange")
                {
                    string item = tokens[1];

                    if (groceries.Contains(item))
                    {
                        string temp = item;

                        groceries.Remove(item);
                        groceries.Add(temp);
                    }
                    else
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", groceries));
        }
    }
}
