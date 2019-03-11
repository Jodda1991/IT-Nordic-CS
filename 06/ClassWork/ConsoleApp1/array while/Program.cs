using System;

namespace array_while
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] array = new int[4];
			array[0] = 2;
			array[1] = 3;
			array[2] = 7;
			array[3] = 11;
			int num = 0;
			int sum=0;

			while (num<4)
			{

					sum = sum + array[num];
					num++;
					Console.WriteLine(sum);
				
			}
		}
	}
}
