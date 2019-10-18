using System;

	namespace p03
	{
		class Program
		{ 
			static void Main(string[] args)
			{
			double miles = double.Parse(Console.ReadLine());
			double kiloMeters = miles * 1.60934;
						
			Console.WriteLine($"{kiloMeters:f2}");
			}
		}
	}
