using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            int down = int.Parse(Console.ReadLine());
            int up = int.Parse(Console.ReadLine());

            for (char index = (char)down; index <= (char)up; index++)
            {
                Console.Write($"{index} ");
            }
            Console.WriteLine();
        }
    }
}
