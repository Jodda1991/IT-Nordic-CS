using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWorkApp
{
	class Program
	{
		static void Main(string[] args)
		{
			var signs = new Dictionary<char, char>();
			signs.Add('(',')');
			signs.Add('[',']');
			Console.WriteLine("Please enter signs. Possible signs are []or()");
			string input = Console.ReadLine();
			KeyValuePair<char, char> elements = signs.ElementAt(0);
			char start = elements.Key;
			char end = elements.Value;
			KeyValuePair<char, char> elements1 = signs.ElementAt(1);
			char start1 = elements1.Key;
			char end1 = elements1.Value;
			int count = 0;

			if ((input.StartsWith(start)&&input.EndsWith(end))||(input.StartsWith(start1)&&input.EndsWith(end1)))
			{
				Console.WriteLine("Correct!");
			}
			else
			{
				Console.WriteLine("Inccorect!");
			}
		}
	}
}
