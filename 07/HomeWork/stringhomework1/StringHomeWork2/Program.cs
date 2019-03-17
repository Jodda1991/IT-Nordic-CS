using System;

namespace StringHomeWork2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter a none empty string !");
			string word = string.Empty;
			while (true)
			{
				word = Console.ReadLine();

				if(string.IsNullOrEmpty(word))
				{
					Console.WriteLine("You entered an empty string ! Try again");
				}
				for (int i = 0; i < word.Length; i++)
				{
					
					word =word.ToLower();
					Console.Write(word[word.Length - i - 1]);
					
				}
				
			}
			
		}
	}
}
