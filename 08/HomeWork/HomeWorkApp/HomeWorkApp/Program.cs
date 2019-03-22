using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWorkApp
{
	class Program
	{
		static void Main(string[] args)
		{
			var signs = new Stack<char>();
			Console.WriteLine("Please enter signs. Possible signs are []or()");
			string input = Console.ReadLine();
			bool correct = true;
			
			foreach (char sign in input)
			{

				if (sign=='(' || sign=='[')
				{
					signs.Push(sign);	
				}

				if (sign ==')')
				{
					if(signs.Count==0)
					{
						throw new Exception("You didnt enter a sign!");
					}
					if(signs.Pop()!='(')
					{
						correct = false;
					}
				}

				if (sign == ']')
				{
					if (signs.Count == 0)
					{
						throw new Exception("You didnt enter a sign!");
					}
					if (signs.Pop() != '[')
					{
						correct = false;
					}
				}
			}
			if (signs.Count != 0)
			{
				Console.WriteLine("You have sign without pair!");
			}
			if (correct)
			{
				Console.WriteLine("Correct");
			}
		}
	}
}
