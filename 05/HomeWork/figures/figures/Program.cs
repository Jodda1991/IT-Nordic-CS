using System;

namespace figures
{
	class Program
	{
		static void Main(string[] args)
		{
			
			try
			{
				Console.WriteLine("Press a number of figure when 1 - circle , 2- equilateral triangle, 3- rectangle:");
				double figure = double.Parse(Console.ReadLine());
				if (figure == 1)
				{
					double perimeter, square;
					Console.WriteLine("Press the diameter of the circle:");
					double diameter = double.Parse(Console.ReadLine());
					Console.WriteLine("Perimeter of the circle is: " + (perimeter = Math.PI * diameter) +
						"\n Square of the circle is : " + (square = Math.PI / 4 * Math.Pow(diameter, 2)));
				}
				else if (figure == 2)
				{
					double perimeter, square;
					Console.WriteLine("Press the side of the equilateral triangle:");
					double side = double.Parse(Console.ReadLine());
					Console.WriteLine("Press the base of the equilateral triangle:");
					double base1 = double.Parse(Console.ReadLine());
					Console.WriteLine("Perimeter of the equilateral triangle is: " + (perimeter = (2 * side + base1)) +
						"\n Square of the equilateral triangle is : " + (square = base1 * (Math.Sqrt(Math.Pow(side, 2) - (Math.Pow(base1, 2) / 4)) / 2)));
				}
				else if (figure == 3)
				{
					double perimeter, square;
					Console.WriteLine("Press the height of the rectangle:");
					double height = double.Parse(Console.ReadLine());
					Console.WriteLine("Press the width of the rectangle:");
					double width = double.Parse(Console.ReadLine());
					Console.WriteLine("Perimeter of the rectangle is: " + (perimeter = 2 * (height + width)) +
						"\n Square of the rectangle is : " + (square = height * width));
				}
				else if (figure<=0)
				{
					Console.WriteLine("You pressed a negative number or null!");
				}
				else if (figure>3)
				{
					Console.WriteLine("You pressed a value more then avaible!");
				}
			}
			catch (FormatException )
			{
				Console.WriteLine("Error! You pressed not a number!");
			}
		}
	}
}
