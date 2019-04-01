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
			Colors allColors = Colors.Black | Colors.Blue | Colors.Cyan
				| Colors.Grey | Colors.Green | Colors.Magenta
				| Colors.Red | Colors.White | Colors.Yellow;

			Console.WriteLine(
				"All colors: {0}",
				string.Join(' ', Enum.GetNames(typeof(Colors))));
			Colors chosenColors = new Colors();
			var chosen=string.Empty;

			for (int i = 0; i < 4; i++)
			{
				Colors color;									
				Console.WriteLine("Choose colors as favorite(you need to choose 4 colors , you can repeat the colors):");
				if (Enum.TryParse<Colors>( Console.ReadLine(), true, out color))
				{
					chosenColors = chosenColors|color;
					chosen = chosenColors.ToString();												
				}
				else
				{
					Console.WriteLine("Error");
				}				
			}
			
			var otherColors = (allColors^chosenColors).ToString();	
			Console.WriteLine("Your favorite colors are :" + chosen);
			Console.WriteLine("Other colors are : " + otherColors);
		}			
	}
}
