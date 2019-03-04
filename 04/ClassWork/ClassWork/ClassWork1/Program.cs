using System;

namespace ClassWork1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Ввведите а");
			double a = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Ввведите h");
			double h = Convert.ToDouble(Console.ReadLine());
			double Sside = 3 * (a * h);
			double Swhole = ((double)3 / 2) * a * (a * Math.Sqrt(3) + 2 * h);
			double V = Math.Pow(a, 2) / 2 * (h / Math.Sqrt(2)*Math.Sqrt(3));
			Console.WriteLine(Sside);
			Console.WriteLine(Swhole);
			Console.WriteLine(V);

		}
	}
}
