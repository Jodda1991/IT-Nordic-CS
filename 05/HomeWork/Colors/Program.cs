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
				"Список возможных цветов: {0}",
				string.Join(' ', Enum.GetNames(typeof(colors))));
			Console.WriteLine("Выберите цвета которые будут помещенны в избранную политру:");
			colors[] colors = new colors[4];
			for (int i = 0; i < 4; i++)
			{
				while (true)
				{
					object color;
					Console.WriteLine("Выберите цвет:");
					if (Enum.TryParse(typeof(colors), Console.ReadLine(), true, out color))
					{
						colors[i] = (colors)color;

					}
					else 
					{
						Console.WriteLine("Ошибка");
					}
					IEnumerable<colors> otherColors1 = colors.Except(Enum.);
					Console.WriteLine("Other colors:"+otherColors1);


				}
			}
			
		}
	}
}
