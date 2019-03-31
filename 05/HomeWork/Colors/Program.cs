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
				object color;
				while (true)
				{					
					Console.WriteLine("Choose colors as favorite:");
					if (Enum.TryParse(typeof(Colors), Console.ReadLine(), true, out color))
					{
						chosenColors = chosenColors|(Colors)color;
						chosen = chosenColors.ToString();						
						break;
					}
					else
					{
						Console.WriteLine("Error");
					}
				}
			}
			
			var otherColors = (allColors^chosenColors).ToString();	
			Console.WriteLine("You favorite colors is :" + chosen);
			Console.WriteLine("Other colors are : " + otherColors);
		}			
	}
}
