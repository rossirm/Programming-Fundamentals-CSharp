using System;

	namespace p02
	{
		class Program
		{ 
			static void Main(string[] args)
			{
			double num1 = double.Parse(Console.ReadLine());
			double num2 = double.Parse(Console.ReadLine());
			double multiply = num1 * num2;
						
			Console.WriteLine($"{multiply:f2}");
			}
		}
	}
