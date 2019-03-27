using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Pet dog = new Pet();
			dog.Kind = "dog";
			dog.Name = "Spotty";
			dog.Sex = 'M';
			dog.DateOfBirth = DateTimeOffset.Parse("2017-02-24");

			dog.WriteDescriptions();
		}
	}
}
