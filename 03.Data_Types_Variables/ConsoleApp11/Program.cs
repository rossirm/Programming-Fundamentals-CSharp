using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            int time = seconds + minutes * 60 + hours * 3600;

            float mPerSecond = (float)distance / (float)time;
            float kmPerHour = (float)(distance/1000)/((float)time/3600);
            float milesPerHour = ((float)distance/1609)/((float)time/3600);
            Console.WriteLine($"{mPerSecond:0.######}");
            Console.WriteLine($"{kmPerHour:0.######}");
            Console.WriteLine($"{milesPerHour:0.######}");
            
        }
    }
}
