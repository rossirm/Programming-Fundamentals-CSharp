using System;
using System.Linq;

namespace p08
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            int result = 0;
            int totalOcc = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];
                int currentOcc = 0;
                for (int j = i; j < numbers.Length; j++)
                {
                    if (currentNum == numbers[j])
                    {
                        currentOcc++;

                        if (currentOcc > totalOcc)
                        {
                            totalOcc = currentOcc;
                            result = currentNum;
                        }                      
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
