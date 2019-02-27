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
				double number1 = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("Enter the operand:");
				char operand = Convert.ToChar(Console.ReadLine());
				Console.WriteLine("Enter the second number:");
				double number2 = Convert.ToDouble(Console.ReadLine());
				double result =0;


				if (operand == '+')
				 {
					result = number1 + number2;
				 }
				 else if (operand == '-')
				 {
					result = number1 - number2;
				 }
				else if (operand == '*')
				 {
					result = number1 * number2;
				 }
				else if (operand == '/')
				 {
					result = number1 / number2;
				 }
				else if (operand == '%')
				{
					result = number1 % number2;
				}
				else if (operand == '^')
				{
					result = Math.Pow(number1, number2);
				}
				else
				{
					Console.WriteLine("Unknown operand ");
				}
				
				Console.WriteLine("The result is: " + result);
			}
		}
	}
}
