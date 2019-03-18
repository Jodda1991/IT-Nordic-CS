using System;
using System.Collections.Generic;
using System.Linq;

namespace queue
{
	class Program
	{
		static void Main(string[] args)
		{
			
			Queue<int> numbers = new Queue<int>();
			
			while (true)
			{
				Console.WriteLine("Enter a command (run or exit)");
				string stopWord = Console.ReadLine();

				if (stopWord == "run")
				{
					while (numbers.Count > 0)
					{
						int number = numbers.Dequeue();
						Console.WriteLine(Math.Pow(number, 2));
					}
				}
				else if (stopWord == "exit")
				{
					break;
				}
				else
				{
					Console.WriteLine("Enter a number");
					numbers.Enqueue(int.Parse(stopWord));
				}

			}
			Console.WriteLine(numbers);
		}
	}
}
