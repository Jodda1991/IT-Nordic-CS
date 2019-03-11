using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите слово:");
			string a;
			do
			{

				a = Console.ReadLine();
				
				if (a=="exit")
				{
					break;
				}

				int lenght = a.Length;
				if (lenght <= 15)
				{
					Console.WriteLine($"Entered string lenght is {lenght}");
				}
				else
				{
					Console.WriteLine("Too long string. Try another:");
					continue;
				}
				
			
			}
			while (true);

		}
	}
}
