using System;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Console.WriteLine("Введите число:");
				Console.WriteLine(int.Parse(Console.ReadLine()) >= 0
					? "оно неотрицатльное"
					: "оно отрицательное");
			}
			catch (FormatException exception)
			{
				Console.WriteLine("Введены неверные данные!");
				Console.WriteLine(exception.Message);

			}
		}
	}
}
