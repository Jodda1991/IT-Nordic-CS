using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassApp
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> newCollection = new List<int> {2,4,8,16,32,64,128,256};
			newCollection.Add(2);
			newCollection.Add(4);
			newCollection.Add(8);
			newCollection.Add(16);
			newCollection.RemoveRange(8, 4);
			newCollection.AddRange(new[] { 512,1024,2048 });

			Console.WriteLine(string.Join(", ", newCollection));

			var figures = new Dictionary<int, string>
			{
				{1,"Triangle" },
				{2,"Circle" }
			};
		}
	}
}
