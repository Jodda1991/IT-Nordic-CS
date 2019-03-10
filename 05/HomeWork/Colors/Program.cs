using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Colors
{
	class Program
	{
		[Flags]
		enum allcolors
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
			var array = Enum.GetValues(typeof(allcolors));
			allcolors ALL = allcolors.Black | allcolors.Blue | allcolors.Cyan
				| allcolors.Grey | allcolors.Green | allcolors.Magenta
				| allcolors.Red | allcolors.White | allcolors.Yellow;
			var all = (allcolors.Black | allcolors.Blue | allcolors.Cyan
				| allcolors.Grey | allcolors.Green | allcolors.Magenta
				| allcolors.Red | allcolors.White | allcolors.Yellow).ToString();

			Console.WriteLine(
				"All colors: {0}",
				string.Join(' ', Enum.GetNames(typeof(allcolors))));
			Console.WriteLine("Choose colors as favorite:");
			allcolors[] favorite = new allcolors[4];

			for (int i = 0; i < 4; i++)
			{

				while (true)
				{

					object color;
					Console.WriteLine("Choose color:");
					if (Enum.TryParse(typeof(allcolors), Console.ReadLine(), true, out color))
					{
						favorite[i] = (allcolors)color;
						var favor = favorite[i].ToString();
						var otherColors = (ALL ^favorite[i]).ToString();
						Console.WriteLine("You favorite color is :"+favor);
						Console.WriteLine("Other colors are : "+otherColors);
						break;

					}
					else
					{
						Console.WriteLine("Error");
					}
				}
			}
		}		
	}
}
