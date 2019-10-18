using System;
using System.Collections.Generic;
using System.Linq;

namespace p07
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

            int[] arguments = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            int bomb = arguments[0];
            int range = arguments[1];

            for (int i = 0; i < number.Count; i++)
            {
                if (number[i] == bomb)
                {
                    if (range <= i)
                    {
                        for (int j = i; j >= i - range; j--)
                        {
                            number[j] = 0;
                        }
                    } if(range > i)
                    {
                        for (int j = i; j >= 0; j--)
                        {
                            number[j] = 0;
                        }
                    }
                    if (range + i >= number.Count - 1)
                    {
                        for (int j = i; j < number.Count; j++)
                        {
                            number[j] = 0;
                        }
                    } if (range + i < number.Count - 1)
                    {
                        for (int j = i; j <= range + 1; j++)
                        {
                            number[j] = 0;
                        }
                    }
                }
            }
            Console.WriteLine(number.Sum());
        }
    }
}
