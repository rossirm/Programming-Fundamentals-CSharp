using System;

	namespace p02
	{
		class Program
		{ 
			static void Main(string[] args)
			{
			string profession = Console.ReadLine();
			int quantity = int.Parse(Console.ReadLine());
			double price = 0.0;
				switch (profession) {
					case "Athlete": 
					price = 0.7 * quantity;
					Console.WriteLine($"The {profession} has to pay {price:f2}.");
					break;
					case "Businessman":
					case "Businesswoman": 
					price = 1.00 * quantity;
					Console.WriteLine($"The {profession} has to pay {price:f2}.");
					break;
					case "SoftUni Student": 
					price = 1.7 * quantity;
					Console.WriteLine($"The {profession} has to pay {price:f2}.");
					break;
					default: 
					price = 1.2 * quantity;
					Console.WriteLine($"The {profession} has to pay {price:f2}.");
					break;	
				}
			}
		}
	}
		