using System;

namespace p02.Add.Two.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }
    }
}