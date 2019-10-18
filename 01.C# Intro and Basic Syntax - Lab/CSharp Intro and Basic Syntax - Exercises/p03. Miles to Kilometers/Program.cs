using System;

namespace p03.MilesToKilometers
{
    class MilesToKilometers
    {
        static void Main()
        {
            double kilometers = double.Parse(Console.ReadLine());
            double miles = kilometers * 1.60934;

            Console.WriteLine($"{miles:f2}");
        }
    }
}