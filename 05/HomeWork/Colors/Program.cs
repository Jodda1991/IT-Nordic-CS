using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Colors
{
	class Program
	{
		[Flags]
		enum Colors
		{
			None=0,
			Black=1,
			Blue=2,
			Cyan=4,
			Grey=8,
			Green=16,
			Magenta=32,
			Red=64,
			White=128,
			Yellow=256,
		}
		static void Main(string[] args)
		{
			var array = Enum.GetValues(typeof(Colors));
			Colors allColors = Colors.Black | Colors.Blue | Colors.Cyan
				| Colors.Grey | Colors.Green | Colors.Magenta
				| Colors.Red | Colors.White | Colors.Yellow;
			var all = (Colors.Black | Colors.Blue | Colors.Cyan
				| Colors.Grey | Colors.Green | Colors.Magenta
				| Colors.Red | Colors.White | Colors.Yellow).ToString();

			Console.WriteLine(
				"All colors: {0}",
				string.Join(' ', Enum.GetNames(typeof(Colors))));
			Console.WriteLine("Choose colors as favorite:");
			Colors[] favorite = new Colors[4];
			Colors chosenColors = Colors.None;
			var favoriteColors=chosenColors;
			var chosen=string.Empty;

			for (int i = 0; i < 4; i++)
			{
				object color;
				while (true)
				{					
					Console.WriteLine("Choose color:");
					if (Enum.TryParse(typeof(Colors), Console.ReadLine(), true, out color))
					{
						favorite[i] = (Colors)color;
						favoriteColors = favorite[i];
						chosen = favoriteColors.ToString();						
						break;
					}
					else
					{
						Console.WriteLine("Error");
					}
				}
				chosenColors = chosenColors | favoriteColors;
			}
			
			var otherColors = (allColors ^ favoriteColors).ToString();	
			Console.WriteLine("You favorite color is :" + chosenColors.ToString());
			Console.WriteLine("Other colors are : " + otherColors);
		}			
	}
}
