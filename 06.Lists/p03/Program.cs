using System;
using System.Collections.Generic;
using System.Linq;

namespace p03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

            int[] conditions = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            List<int> result = new List<int>();
            int elementsToTake = conditions[0];
            int elementsToDelete = conditions[1];
            for (int i = 0; i < elementsToTake; i++)
            {
                result.Add(inputList[i]);
            }


            for (int i = 0; i < elementsToDelete; i++)
            {
                result.RemoveAt(0);
            }
            /*
            if (result.Contains(conditions[2])) {
                Console.WriteLine("YES!");
            } else {
                Console.WriteLine("NO!");
            }
            */
            for (int i = 0; i < result.Count; i++)
            {
                if(result[i] == conditions[2])
                {
                    Console.WriteLine("YES!");
                    return;
                }
            }
            Console.WriteLine("NO!");
        }
    }
}
