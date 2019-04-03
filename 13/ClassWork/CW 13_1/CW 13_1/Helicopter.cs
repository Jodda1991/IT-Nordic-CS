using System;
using System.Collections.Generic;
using System.Text;

namespace CW_13_1
{
	public class Helicopter:CommonProperties
	{
		public byte BladesCount { get; private set; }

		public Helicopter(int maxHeight,byte bladesCount):base(maxHeight)
		{
			bladesCount = BladesCount;
		}

		public void WriteAllProperties ()
		{
			Console.WriteLine($"{nameof(BladesCount)}:{BladesCount}" +
								$"{nameof(CurrentHeight)}:{CurrentHeight}" +
								$"{nameof(MaxHeight)}:{MaxHeight}");
		}
	}
}
