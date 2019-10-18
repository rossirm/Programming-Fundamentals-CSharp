using System;

namespace p05
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isTrue = Convert.ToBoolean(input);
            if (isTrue)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
