using System;

namespace CW_16
{
	class Program
	{
		static void Main(string[] args)
		{
			const double unchangeble = 1.8; 
			var circle = new Circle(unchangeble);

			var square = circle.Calculate(
				(double r) => Math.PI* Math.Pow(unchangeble, 2)
			);

			Console.WriteLine(square);

			Calculation s = new Calculation(new[] { 1, 4, 12,48 });
			var y=s.CalcSingleValue((int[] array) =>
			{
				int arr = 0;
				foreach (int z in array)
				{
					arr =+ z;
				}
				return arr / array.Length;
			});
			Console.WriteLine(y);
		}

	}
}
