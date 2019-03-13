using System;

namespace ClassApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter two natural numbers:");
			double a = double.Parse(Console.ReadLine());
			double b = double.Parse(Console.ReadLine());
			

			Console.WriteLine(a + "*" + b+"="+ a * b);
			Console.WriteLine("{0:##.##}+{1:##.##}={2:##.##}", a, b, a + b);
			Console.WriteLine($"{a:##.##}-{b:##.##}={a - b:##.##}");


		}
	}
}
