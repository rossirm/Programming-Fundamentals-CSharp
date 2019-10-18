using System;
using System.Collections.Generic;
using System.Linq;

namespace p01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

            int currentStart = 0;
            int currentLength = 1;
            int bestStart = 0;
            int bestLength = 1;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i-1])
                {
                    currentLength++;
                    if(currentLength > bestLength)
                    {
                        bestLength = currentLength;
                        bestStart = currentStart;
                    }
                } else
                {
                    currentLength = 1;
                    currentStart = i;
                }
            }

            for (int i = bestStart; i < bestStart + bestLength; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
