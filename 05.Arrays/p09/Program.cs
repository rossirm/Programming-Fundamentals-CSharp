using System;
using System.Linq;

namespace p09
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] firstArr = Console.ReadLine()
            //.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            //.ToArray();

            string word = Console.ReadLine();
            char[] letters = new char[26];

            int indexCounter = 0;
            for (char letter = 'a'; letter <= 'z'; letter++)
            {
                letters[indexCounter] = letter;
                indexCounter++;
            }
            for (int i = 0; i < word.Length; i++)
            {
                char currentLetter = word[i];
                for (int j = 0; j < letters.Length; j++)
                {
                    if (currentLetter == letters[j])
                    {
                        Console.WriteLine($"{currentLetter} -> {j}");
                    } 
                }
            }
        }
    }
}
