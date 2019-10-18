using System;

	class p08 {
		static void Main(string[] args) {
		
			int first = int.Parse(Console.ReadLine());
			int second = int.Parse(Console.ReadLine());
			
			for (int i = Math.Min(first, second); i <= Math.Max(second, first); i++) {
				Console.WriteLine(i);
			}
		}
	}
