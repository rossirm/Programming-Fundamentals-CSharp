using System;

namespace p04
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int number2 = Convert.ToInt32(number, 16);
            

            Console.WriteLine(number2);
        }
    }
}
