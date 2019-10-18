using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
           int Do = int.Parse(Console.ReadLine());
for (int isPrime = 2; isPrime <= Do; isPrime++)
{    bool TowaLIE = true;
         for (int delio = 2; delio <= Math.Sqrt(isPrime); delio++)
    {
        if  (isPrime % delio == 0)
        {
            TowaLIE = false;
            break;
        }
    }
    Console.WriteLine($"{isPrime} -> {TowaLIE}");
}

        }
    }
}
