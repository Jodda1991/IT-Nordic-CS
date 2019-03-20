using System;

namespace structure
{

	class Program
	{
		static void Main(string[] args)
		{
			int a = 0;
			Increment(a);
			Console.WriteLine(nameof(a) + "=" + a);
		}

		static void Increment (int val)
		{
			val++;
			Console.WriteLine(nameof(val) + "=" + val);
		}

		static void AddSuffix(string message)
		{
			message = message + "(suffix)";

		}
	}
}
