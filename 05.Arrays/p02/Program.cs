using System;
using System.Linq;

namespace p02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            int rotation = int.Parse(Console.ReadLine());
            int[] result = new int[numbers.Length];

            for (int rotations = 0; rotations < rotation; rotations++)
            {
                int current = numbers[numbers.Length - 1];
                // moves to right from 1. element
                for (int index = numbers.Length - 1; index > 0; index--)
                {
                    numbers[index] = numbers[index - 1];
                    result[index] += numbers[index];
                }
                numbers[0] = current;
                result[0] += numbers[0];
            }
            for (int j = 0; j < result.Length; j++)
            {
                Console.Write(result[j] + " ");
            }
            Console.WriteLine();
        }
    }
}
