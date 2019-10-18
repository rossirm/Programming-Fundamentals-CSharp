using System;

namespace p05.CharacterStats
{
    class CharacterStats
    {
        static void Main()
        {
            string name = Console.ReadLine();
            short health = short.Parse(Console.ReadLine());
            short maxHealth = short.Parse(Console.ReadLine());
            short energy = short.Parse(Console.ReadLine());
            short maxEnergy = short.Parse(Console.ReadLine());

            Console.WriteLine("Name: {0}", name);
            //Prints the current health
            Console.Write("Health: |");
            Console.Write(new string('|', health));
            Console.Write(new string('.', maxHealth - health));
            Console.WriteLine("|");
            //Prints the current energy
            Console.Write("Energy: |");
            Console.Write(new string('|', energy));
            Console.Write(new string('.', maxEnergy - energy));
            Console.WriteLine("|");
        }
    }
}