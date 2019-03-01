using System;

namespace Array
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] names = new string[3];
			int[] ages = new int[3];

			for (int i = 0; i < names.Length; i++)
			{
				Console.WriteLine("Enter your name:");
				names[i] = Console.ReadLine();
			}
			for (int i = 0; i < ages.Length; i++)
			{
				Console.WriteLine("Enter your age:");
				ages[i] = Convert.ToInt32(Console.ReadLine());
			}
			for (int i = 0; i < 3; i++)
			{
				Console.WriteLine($"Name: {names[i]}, age in 4 years: {ages[i] + 4}");

			}
		}
	}
}
