using System;

namespace String
{
	class Program
	{
		static void Main(string[] args)
		{
			var test = "my test string";
			Console.WriteLine(test.Substring(8, 2));

			string[] words = test.Split(" ");
			foreach (string word in words)
				Console.WriteLine(word);
		}
	}
}
