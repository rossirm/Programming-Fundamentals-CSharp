using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'y':
                    Console.WriteLine("vowel");
                    break;

                case (char)'0':
                case (char)'1':
                case (char)'2':
                case (char)'3':
                case (char)'4':
                case (char)'5':
                case (char)'6':
                case (char)'7':
                case (char)'8':
                case (char)'9':
                    Console.WriteLine("digit");
                    break;

                default:
                    Console.WriteLine("other");
                    break;
            }         
        }
    }
}
