using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listGrocery = Console.ReadLine()
                 .Split('!')
                 .ToList();  // read input and create a List

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Go Shopping!")
                {
                    Console.WriteLine(string.Join(", ", listGrocery));
                    break;
                }

                List<string> typeCommand = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToList(); // create a list of commands

                string currCommand = typeCommand[0];
                string currItem = typeCommand[1];
                // string newItem = typeCommand[2];

                if (currCommand == "Urgent")
                {
                    if (!(listGrocery.Contains(currItem)))
                    {
                        listGrocery.Insert(0, currItem);
                    }
                }
                else if (currCommand == "Unnecessary")
                {
                    if (listGrocery.Contains(currItem))
                    {
                        int index = listGrocery.IndexOf(currItem);
                        listGrocery.RemoveAt(index);
                        //listGrocery.Remove(currItem);
                    }
                }
                else if (currCommand == "Correct")
                {
                    string newItem = typeCommand[2];

                    if (listGrocery.Contains(currItem))
                    {
                        int index = listGrocery.IndexOf(currItem);
                        listGrocery[index] = newItem;
                    }
                }
                else if (currCommand == "Rearrange")
                {
                    if (listGrocery.Contains(currItem))
                    {
                        int index = listGrocery.IndexOf(currItem);
                        listGrocery.Add(currItem);
                        //listGrocery.Remove(currItem);
                        listGrocery.RemoveAt(index);
                    }
                }
            }            
        }
    }
}
