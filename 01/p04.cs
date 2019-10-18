using System;

	namespace p04
	{
		class Program
		{ 
			static void Main(string[] args)
			{
				string name = Console.ReadLine();
				int volume = int.Parse(Console.ReadLine());
				int energyContentPer100 = int.Parse(Console.ReadLine());
				int sugarContentPer100 = int.Parse(Console.ReadLine());
						
				double totalEnergy = (double)(energyContentPer100 * volume) / 100;
				double totalSugar = (double)(sugarContentPer100 * volume) / 100;
				
			Console.WriteLine($"{volume}ml {name}:\r\n{totalEnergy}kcal, {totalSugar}g sugars");
			}
		}
	}
