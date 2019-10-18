using System;
using System.Linq;

namespace p05
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] symbols1 = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(char.Parse)
            .ToArray();

            char[] symbols2 = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(char.Parse)
            .ToArray();

            int length = Math.Min(symbols1.Length, symbols2.Length);

            bool isFirst = false;
            for (int index = 0; index < length; index++)
            {
                if (symbols1[index] != symbols2[index])
                {
                    if (symbols1[index] < symbols2[index])
                    {
                        isFirst = true;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            if (isFirst)
            {
                Console.WriteLine(string.Join("", symbols1));
                Console.WriteLine(string.Join("", symbols2));
            }
            else
            {
                if (symbols1.Length < symbols2.Length)
                {
                    Console.WriteLine(string.Join("", symbols1));
                    Console.WriteLine(string.Join("", symbols2));
                }
                else
                {
                    Console.WriteLine(string.Join("", symbols2));
                    Console.WriteLine(string.Join("", symbols1));
                }

            }
        }
    }
}
