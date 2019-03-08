using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Colors
{
	class Program
	{
		[Flags]
		enum colors
		{
			Black,
			Blue,
			Cyan,
			Grey,
			Green,
			Magenta,
			Red,
			White,
			Yellow
		}
		static void Main(string[] args)
		{
			var array = Enum.GetValues(typeof(colors));

			Console.WriteLine(
				"All colors: {0}",
				string.Join(' ', Enum.GetNames(typeof(colors))));
			Console.WriteLine("Choose colors as favorite:");
			colors[] OtherColors = new colors[9];
			colors[] colors = new colors[4];
			for (int i = 0; i < 4; i++)
			{
				while (true)
				{
					object color;
					Console.WriteLine("Choose color:");
					if (Enum.TryParse(typeof(colors), Console.ReadLine(), true, out color))
					{
						colors[i] = (colors)color;

					}
					else 
					{
						Console.WriteLine("Error");
					}
					//пока не нашел способ как отобразить цвета невошедшие в палитру
					IEnumerable<colors> otherColors1 = colors.Except(OtherColors);
					Console.WriteLine("Other colors:"+otherColors1);


				}
			}
			
		}
	}
}
