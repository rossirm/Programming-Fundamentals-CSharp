using System;

	namespace p01
	{
		class Program
		{ 
			static void Main(string[] args)
			{
			string profession = Console.ReadLine();
			if (profession == "Athlete") 
				Console.WriteLine("Water");
			 else if ((profession == "Businessman") || (profession == "Businesswoman")) 
				Console.WriteLine("Coffee");
			 else if (profession == "SoftUni Student") 
				Console.WriteLine("Beer");
			 else 
				Console.WriteLine("Tea");
			
			}
		}
	}
		