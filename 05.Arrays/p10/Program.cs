using System;
using System.Linq;

namespace p10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            int difference = int.Parse(Console.ReadLine());

            int counter = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int current = number[i];
                for (int j = i; j < number.Length; j++)
                {
                    if (Math.Abs(current - number[j]) == difference)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
