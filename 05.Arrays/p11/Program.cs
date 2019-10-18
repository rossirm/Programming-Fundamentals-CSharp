using System;
using System.Linq;

namespace p11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            bool isFound = false;

            for (int i = 0; i < number.Length; i++)
            {
                int[] firstArr = number.Take(i).ToArray();
                int[] secondArr = number.Skip(i + 1).ToArray();

                if (firstArr.Sum() == secondArr.Sum())
                {
                    Console.WriteLine(i);
                    isFound = true;
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
