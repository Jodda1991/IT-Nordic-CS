using System;

namespace HomeWork10
{
	class Program
	{
		static void Main(string[] args)
		{
			Person[] people = new Person[3];

			for (int i = 0; i<3;i++)
			{
				people[i] = new Person();
				Console.WriteLine("Enter person's name:");
				people[i].Name = Console.ReadLine();
				Console.WriteLine("Enter person's age:");
				people[i].Age = int.Parse(Console.ReadLine());
			}

			for (int i=0; i < 3; i++)
			{
				Console.WriteLine(people[i].Output);
			}
		}
	}
}
