using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string hexa = Convert.ToString(number, 16).ToUpper();
            string binary = Convert.ToString(number, 2);

            Console.WriteLine(hexa);
            Console.WriteLine(binary);

        }
    }
}
