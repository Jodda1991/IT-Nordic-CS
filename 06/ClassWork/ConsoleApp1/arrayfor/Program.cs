using System;

namespace arrayfor
{
	class Program
	{
		static void Main(string[] args)
		{
			var marks = new[]
			{
				new []{2,3,3,2,3},
				new []{2,4,5,3},
				null,
				new []{5,5,5,5},
				new []{4}


		    };
			for (int i =0;i<marks[0].Length;i++)
			{
				for(int a=0;a<marks[1].Length;a++)
				{
					
					Console.WriteLine();
				}
			}
		}
	}
}
