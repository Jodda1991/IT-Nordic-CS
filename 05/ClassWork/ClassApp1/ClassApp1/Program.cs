using System;

namespace ClassApp1
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
			Console.WriteLine("Выберите цвета которые будут помещен в избранную политру:");
			colors[] colors = new colors[4];
			for(int i =0; i<4;i++)
			{
				while (true)
				{
					object color;
					Console.WriteLine("Выберите цвет:");
					if (Enum.TryParse(typeof(colors), Console.ReadLine(), true, out color))
					{
						colors[i] = (colors)color;
						Console.WriteLine(colors[i]);
						break;

					}
					else
					{
						Console.WriteLine("Ошибка");
					}
					
				}
			}
			if ()
		}
	}
}
