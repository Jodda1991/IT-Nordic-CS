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
			bool condition = true;
			char[] digits = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};

			while (true)
			{
				enteredWords = Console.ReadLine();
				
				foreach (char digit in digits)
				{
					if (enteredWords.Contains(digit))
					{
						Console.WriteLine("Error! Unavaible symbols! Try again !");
						condition = false;
						break;
					}
				}
				if (condition && enteredWords.Contains(" ") && !string.IsNullOrWhiteSpace(enteredWords))
				{
					
					break;

				}
				Console.WriteLine("You entered less then 2 words! Try again !");
			}
			string[] words = enteredWords.Split(new char[] { ' ', ',', '.', ':', '\t' }, StringSplitOptions.RemoveEmptyEntries);

			for (int i = 0; i < words.Length; i++)
				{
					if (words[i].StartsWith("A", StringComparison.InvariantCultureIgnoreCase))
					{
						wordsWithA++;
					}
				}
			
			
			Console.WriteLine($"Words start with A are {wordsWithA}");
		}
	}
}
