using System;

namespace HomeWork1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter a positive integer value:");
			string Integer;
			int evenNumber = 0;
			while(true)
			{
				Integer = Console.ReadLine();
				try
				{
					
					for (int i = 0; i < Integer.Length; i++)
					{
						if ((int.Parse(Integer) % 2) == 0)
						{
							evenNumber++;

						}
						while (int.Parse(Integer) <= 0)
						{

							throw new Exception("You entered a negative number !");

						}
					}
					Console.WriteLine($"Total quantity of even numbers is: {evenNumber}");
					break;
				}
				catch (OverflowException)
				{
					Console.WriteLine("Your number more then integer max value!");
				}
				catch(FormatException)
				{
					Console.WriteLine("You entered not a number!");
				}
			}
		}
	}
}
