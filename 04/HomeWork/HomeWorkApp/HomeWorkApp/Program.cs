using System;

namespace HomeWorkApp
{
	class Program
	{
		[Flags]
		enum capacity : byte
		{
			pack1 = 0x0,
			pack5 = 0x0 << 1,
			pack20 = 0x0 << 2,

		}
		static void Main(string[] args)
		{
			Console.WriteLine("What volume of juice do you need to pack?:");
			double volume = Convert.ToDouble(Console.ReadLine());

			int package1 = 1;
			int package5 = 5;
			int package20 = 20;
			capacity UsedPacks = (capacity.pack1^capacity.pack5)|capacity.pack20;
			double juicepack5 = Math.Floor((volume % package20) / package5);
			double juicepack20 = Math.Floor(volume / package20);
			double juicepack1 = Math.Floor(((volume % package20) % package5) / package1);

			Console.WriteLine($"You need:\n{juicepack20} 20l packs" +
							  $"\n{juicepack5} 5l packs" +
							  $"\n{juicepack1} 1L packs");
			//Хотел сделать , чтобы в битах отображались использованные упаковки , но пока не придумал как можно использовать, отображается только pack1
			if (juicepack1 > 0)
			{
				UsedPacks = UsedPacks ^ capacity.pack1;
			}
			else if (juicepack5>0)
			{
				UsedPacks = UsedPacks ^ capacity.pack5;
			}
			else if (juicepack20>0)
			{
				UsedPacks = UsedPacks ^ capacity.pack20;
			}
			Console.WriteLine(UsedPacks);
		}
	}
}
