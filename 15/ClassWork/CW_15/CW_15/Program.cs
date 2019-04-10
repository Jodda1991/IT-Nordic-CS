using System;

namespace CW_15
{
	class Program
	{
		static void Main(string[] args)
		{
			Account<int> client1 = new Account<int>(10012, "Bob");
			client1.WriteProperties();

			Account<string> client2 = new Account<string>("10044", "Jim");
			client2.WriteProperties();

			Account<Guid> client3 = new Account<Guid>(Guid.NewGuid(),"Tim" );
			client3.WriteProperties();
		}
	}
}
