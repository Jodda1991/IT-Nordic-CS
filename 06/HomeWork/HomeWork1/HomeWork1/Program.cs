using System;

namespace HomeWork1
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Console.WriteLine("Enter a positive integer value:");
				string rawInput = Console.ReadLine();
				int input = int.Parse(rawInput);
				int evenNumber = 0;

				while (true)
				{
					foreach (char digit in rawInput)
					{
						if ((int)digit % 2 == 0)
						{
							evenNumber++;
						}
						while (input <= 0)
						{
							throw new Exception("You entered a negative number !");
						}
					}
				Console.WriteLine($"Total quantity of even numbers is: {evenNumber}");
				break;
				}
			}
			catch (OverflowException)
			{
				Console.WriteLine("Your number more then integer max value!");
			}
			catch (FormatException)
			{
				Console.WriteLine("You entered not a number!");
			}
		}
	}
}
