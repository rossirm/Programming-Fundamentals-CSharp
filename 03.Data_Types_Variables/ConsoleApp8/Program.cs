using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string lastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char sex = char.Parse(Console.ReadLine());
            long iD = long.Parse(Console.ReadLine());
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine($"First name: {name}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {sex}");
            Console.WriteLine($"Personal ID: {iD}");
            Console.WriteLine($"Unique Employee number: {number}");
        }
    }
}
