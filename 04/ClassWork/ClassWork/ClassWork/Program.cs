using System;

namespace ClassWork
{
	class Program
	{
		static void Main(string[] args)
		{
			
				long a = long.Parse(Console.ReadLine());
				int b;

				if (a <= int.MaxValue && a>=int.MinValue)
				{
					b = (int)a;
					Console.WriteLine(b);
				}
				else
				{
					Console.WriteLine("error");
				}
			
		}
	}
}
