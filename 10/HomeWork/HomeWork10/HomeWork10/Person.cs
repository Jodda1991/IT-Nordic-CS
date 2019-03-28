using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork10
{
	class Person
	{
		public string Name { get; set; }
		public int  Age  { get; set; }

	public int AgesInFourYears
		{
			get
			{
				return (Age + 4);
			}
		}
		public string Output
		{
			get{ return $"Name: {Name} ,in 4 years: {AgesInFourYears}";}
		}
	}
}
