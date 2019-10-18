using System;

	namespace p05
	{
		class Program
		{ 
			static void Main(string[] args)
			{
				string name = Console.ReadLine();
				int currentHealth = int.Parse(Console.ReadLine());
				int maximumHealth = int.Parse(Console.ReadLine());
				int currentEnergy = int.Parse(Console.ReadLine());
				int maximumEnergy = int.Parse(Console.ReadLine());
						
				string health = "|" + new string('|', currentHealth) + new string('.', maximumHealth - currentHealth) + "|";
				string energy = "|" + new string('|', currentEnergy) + new string('.', maximumEnergy - currentEnergy) + "|";
				
			Console.WriteLine($"Name: {name}");
			Console.WriteLine($"Health: {health}");
			Console.WriteLine($"Energy: {energy}");
			}
		}
	}
