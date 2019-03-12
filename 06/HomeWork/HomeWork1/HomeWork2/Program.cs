using System;

namespace HomeWork2
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				double deposit, percentage, expectedDeposit, days = 0;
				Console.WriteLine("Enter your deposit number in rubbles:");
				deposit = double.Parse(Console.ReadLine());
				Console.WriteLine("Enter a daily percentage(1%=0,01):");
				percentage = double.Parse(Console.ReadLine());
				Console.WriteLine("Enter an expected deposit:");
				expectedDeposit = double.Parse(Console.ReadLine());
				double percent = deposit * percentage;
				if (deposit <= -1)
				{
					throw new Exception("Inccorect! Value have to more then zero !");
				}
				if (percentage <= -1)
				{
					throw new Exception("Inccorect! Value have to more then zero !");
				}
				if (expectedDeposit <= -1)
				{
					throw new Exception("Inccorect! Value have to more then zero !");
				}
				while (true)
				{
					
					while (deposit < expectedDeposit)
					{

						deposit = deposit + percent;
						days++;

					}
					Console.WriteLine($"You need to wait {days} days");
					break;
				}
			}
			catch (FormatException)
			{
				Console.WriteLine("You entered not a number!");
			}
		}
	}
}
