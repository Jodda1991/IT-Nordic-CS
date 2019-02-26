using System;
using System.Threading;

namespace DemoApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter your name:");
			string name = Console.ReadLine();
			Thread.Sleep(5000);
			Console.WriteLine($"Hello {name}!");
			Thread.Sleep(5000);
			Console.WriteLine($"Goodbye {name}!");
			Console.ReadKey();
		}
	}
}
