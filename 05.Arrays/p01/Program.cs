using System;
using System.Linq;

class p01
{
    static void Main()
    {
        string[] firstArr = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        string[] secondArr = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        int length = Math.Min(firstArr.Length, secondArr.Length);
        int equalElements = 0;

        for (int index = 0; index < length; index++)
        {
            if (firstArr[index] == secondArr[index])
            {
                equalElements++;
            }
        }
        Array.Reverse(firstArr);
        secondArr = secondArr.Reverse().ToArray();

        int reverseCounter = 0;

        for (int index = 0; index < length; index++)
        {
            if (firstArr[index] == secondArr[index])
            {
                reverseCounter++;
            }
        }

        if (equalElements > reverseCounter)
        {
            Console.WriteLine(equalElements);
        }
        else
        {
            Console.WriteLine(reverseCounter);
        }
    }
}