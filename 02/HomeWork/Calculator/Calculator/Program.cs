using System;

namespace Calculator
{
	class Program
	{
		static void Main(string[] args)
		{

			while (true)
			{
				Console.WriteLine("Enter the first number:");
				double num1 = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("Enter the opperand:");
				char operrand = Convert.ToChar(Console.ReadLine());
				Console.WriteLine("Enter the second number:");
				double num2 = Convert.ToDouble(Console.ReadLine());

				if (operrand == '+')
				{
					double result1 = num1 + num2;
					Console.WriteLine("The result is: " + result1);
				}
				else if (operrand == '-')
				{
					double result2 = num1 - num2;
					Console.WriteLine("The result is: " + result2);
				}
				else if (operrand == '*')
				{
					double result3 = num1 * num2;
					Console.WriteLine("The result is: " + result3);
				}
				else if (operrand == '/')
				{
					double result4 = num1 / num2;
					Console.WriteLine("The result is: " + result4);
				}
				else if (operrand == '%')
				{
					double result5 = num1 % num2;
					Console.WriteLine("The result is: " + result5);
				}
				else if (operrand == '^')
				{
					double result6 = Math.Pow(num1, num2);
					Console.WriteLine("The result is: " + result6);
				}
				else
				{

					Console.WriteLine("Unknown opperand ");
				}				
			}
		}
	}
}
