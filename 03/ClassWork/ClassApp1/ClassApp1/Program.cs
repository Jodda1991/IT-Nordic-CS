using System;

namespace ClassApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			/*object number1 = 10D;
			object number2 = 4.5544;
			Console.WriteLine((double)number1 * (double)number2);

			dynamic tt = 10;
			dynamic to = "345,55";
			
			Console.WriteLine(tt +double.Parse(to) );*/

			string[] array = new string[5];


			/*array[0] = "ab1";
			array[1] = "ab2";
			array[2] = "ab3";
			array[3] = "ab4";
			array[4] = "ab5";*/

			for (int i = 0; i < array.Length; i++)
			{
				array[i]= Console.ReadLine();
			}
			for (int i = 0; i < array.Length; i++)
			{
				Console.WriteLine(array[i]);
			}





		}
	}
}
