using System;

namespace ClassWork_12
{
	class Program
	{
		static void Main(string[] args)
		{
			BaseDocument b1 = new BaseDocument("Drive Licence","002",DateTimeOffset.Parse("02-04-2001"));
			b1.WriteToConsole();

			Passport p1 = new Passport("001",DateTimeOffset.Parse("01-07-2008"));
			p1.WriteToConsole();


			var documents = new BaseDocument[3];

			documents[1] = new BaseDocument("Bill", "003", DateTimeOffset.Parse("01-01-2000"));
			documents[2] = new BaseDocument("Bill", "003", DateTimeOffset.Parse("01-01-2000"));
			documents[3] = new Passport("003", DateTimeOffset.Parse("01-01-2000"),"Germany","Kurt");

			foreach(var z in documents)
			{
				if(z is Passport)
				{
					(Passport)z.ChangeIssueDate)
				}
			}
		}
	}
}
