using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassWork
{
	class Program
	{
		static void Main(string[] args)
		{
			Stack<int> dishes = new Stack<int>();
			string command = Console.ReadLine();
			Console.WriteLine("Enter your command (wash,dry or exit) or number of the dish");
			if(command =="wash")
			{
				dishes.Push(1);
			}
			else if (command=="dry")
			{
				dishes.Count
			}
		}
	}
}
