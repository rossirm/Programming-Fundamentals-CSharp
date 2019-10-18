using System;
using System.Collections.Generic;
using System.Linq;

namespace p04_Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emailBook = new Dictionary<string, string>();
            string name = "";
            string email = "";
            string command = Console.ReadLine();

            while(command != "stop")
            {
                name = command;
                email = Console.ReadLine();
                if (!emailBook.ContainsKey(name))
                {
                    emailBook.Add(name, email);
                } else
                {

                }
                command = Console.ReadLine();
            }
            foreach (var pair in emailBook.Where(x => !x.Value.EndsWith(".us") && !x.Value.EndsWith(".uk")))
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
