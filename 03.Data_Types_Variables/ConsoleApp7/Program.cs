using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = a;
            a = b;
            b = c;
            Console.WriteLine($"Before:\r\n a = {b}\r\n b = {a}\r\n After:\r\n a = {a}\r\n b = {b}");
        }
    }
}
