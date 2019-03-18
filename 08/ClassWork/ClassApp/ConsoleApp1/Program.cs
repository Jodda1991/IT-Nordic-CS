using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			var countries = new Dictionary<string, string>();
			countries.Add("Russia","Moscow");
			countries.Add("Germany","Berlin");
			countries.Add("France","Paris");
			countries.Add("Jordan","Amman");
			Console.WriteLine("Try to guess the country by capital");


			KeyValuePair<string, string> elements = countries.ElementAt(new Random().Next(4));
			string capital = elements.Value;
			string country = elements.Key;
			
			while (true)
			{
				string choose = Console.ReadLine();
				if (choose = capital)
				{
					Console.WriteLine("Well Done!");
					break;
				}
				else
				{
					Console.WriteLine("Wrong! Try again");
					
				}
				
			}
			


			

			



		}
	}
}
