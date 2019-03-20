using System;

namespace stringhomework1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter string with more then 2 words");
			var enteredWords=string.Empty;
			int wordsWithA = 0;
			char[] digits = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
			string[] words; 
			while (true)
			{
				enteredWords = Console.ReadLine();
				words = enteredWords.Split(' ', StringSplitOptions.RemoveEmptyEntries);
				if (words.Length >= 2)
				{
					break;
				}
				foreach (char digit in digits)
				{
					if (enteredWords.Contains(digit))
					{
						Console.WriteLine("Error! Unavaible symbols! Try again !");
						break;
					}
				}
				
				Console.WriteLine("You entered less then 2 words! Try again !");
			}			
			foreach (string word in words)
			{
				if (word.StartsWith("A", StringComparison.CurrentCultureIgnoreCase))
				{
					wordsWithA++;
				}
			}
			
			Console.WriteLine($"Words start with A are {wordsWithA}");
		}
	}
}
