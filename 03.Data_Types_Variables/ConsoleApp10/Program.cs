using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int century = int.Parse(Console.ReadLine());
            int years = century * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            decimal minutes = hours * 60;
            decimal seconds = minutes * 60;

            Console.WriteLine($"{century} centuries = {years} years = " +
                $"{days} days = {hours} hours = {minutes} minutes = " +
                $"{seconds} seconds = {seconds}000 milliseconds = {seconds}000000 microseconds = " +
                $"{seconds}000000000 nanoseconds");
        }
    }
}
