using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWorkApp
{
	class Program
	{
		static void Main(string[] args)
		{
			var signs = new Dictionary<string, string>();
			signs.Add("(",")");
			signs.Add("[","]");
			Console.WriteLine("Please enter signs. Possible signs are []or()");
			string input = Console.ReadLine();
			KeyValuePair<string, string> elements = signs.ElementAt(0);
			string start = elements.Key;
			string exit = elements.Value;
			KeyValuePair<string, string> elements1 = signs.ElementAt(1);
			string start1 = elements1.Key;
			string exit1 = elements1.Value;

			if ((input.StartsWith(start)&&input.EndsWith(exit))||(input.StartsWith(start1)&&input.EndsWith(exit1)))
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
