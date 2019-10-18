using System;
using System.Linq;
using System.Collections.Generic;

namespace p01A_phoneBook_p02
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            string[] command = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

            while(command[0] != "END")
            {
                if (command[0] == "A")
                {
                    if (!phoneBook.ContainsKey(command[1]))
                    {
                        phoneBook.Add(command[1], command[2]);
                    }
                    else
                    {
                        phoneBook[command[1]] = command[2];
                    }
                } else if (command[0] == "S")
                {
                    if (!phoneBook.ContainsKey(command[1]))
                    {
                        Console.WriteLine($"Contact {command[1]} does not exist.");
                        }
                    else
                    {
                        Console.WriteLine($"{command[1]} -> {phoneBook[command[1]]}");
                    }
                }

                // p02 phoneBook Upgrade

                /* else if (command[0] == "ListAll")
                {
                    foreach (var pair in phoneBook.OrderBy(x => x.Key))
                    {
                        Console.WriteLine($"{pair.Key} -> {pair.Value}");
                    }
                } */
                command = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }
        }
    }
}
