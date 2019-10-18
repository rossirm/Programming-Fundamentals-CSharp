using System;
using System.Linq;
 
public class SequenceOfCommands_broken
{
 
    public static void Main()
    {
        Console.ReadLine();
        long[] numbers = Console.ReadLine()
            .Split(' ')
            .Select(long.Parse)
            .ToArray();
        string commandLine = Console.ReadLine();
 
        while (!commandLine.Equals("stop"))
        {
            int[] arguments = new int[2];
            string[] stringParams = commandLine.Split(' ');
            if (stringParams.Length > 1)
            {
                arguments[0] = int.Parse(stringParams[1]);
                arguments[1] = int.Parse(stringParams[2]);
            }
            numbers = PerformAction(numbers, stringParams[0], arguments);
            ArrayWriteLine(numbers);
            commandLine = Console.ReadLine();
        }
    }
 
    static long[] PerformAction(long[] nums, string action, int[] args)
    {
        int index = args[0] - 1;
        int value = args[1];
 
        switch (action)
        {
            case "multiply":
                nums[index] *= value;
                break;
            case "add":
                nums[index] += value;
                break;
            case "subtract":
                nums[index] -= value;
                break;
            case "lshift":
                nums = ShiftElementsLeft(nums);
                break;
            case "rshift":
                nums = ShiftElementsRight(nums);
                break;
        }
        return nums;
    }
 
    private static long[] ShiftElementsRight(long[] array)
    {
        long lastElement = array[array.Length-1];
        for (int i = array.Length - 1; i >= 1; i--)
        {
            array[i] = array[i - 1];
        }
        array[0] = lastElement;
        return array;
    }
 
    private static long[] ShiftElementsLeft(long[] array)
    {
        long firstElement = array[0];
        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }
        array[array.Length - 1] = firstElement;
        return array;
    }
 
    private static void ArrayWriteLine(long[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}