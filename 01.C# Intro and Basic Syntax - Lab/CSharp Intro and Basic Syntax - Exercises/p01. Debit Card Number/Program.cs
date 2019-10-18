using System;

namespace p01.DebitCardNumber
{
    class DebitCardNumber
    {
        static void Main()
        {
            short num1 = short.Parse(Console.ReadLine());
            short num2 = short.Parse(Console.ReadLine());
            short num3 = short.Parse(Console.ReadLine());
            short num4 = short.Parse(Console.ReadLine());

            Console.WriteLine($"{num1:d4} {num2:d4} {num3:d4} {num4:d4}");
        }
    }
}