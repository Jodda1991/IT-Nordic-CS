using System;
using System.Collections.Generic;
using System.Text;

namespace CW_15
{
	public class Account <T>
	{
		public T Id { get; private set; }

		public string Name { get; private set; }

		public Account (T id,string name)
		{
			 Id=id;
			name = Name;
		}

		public void WriteProperties()
		{
			Console.WriteLine($"Client's Id {Id}, client's name{Name}");
		}
	}
}
