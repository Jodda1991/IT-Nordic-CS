using System;
using System.Collections.Generic;
using System.Text;

namespace CW_13_1
{
	interface IPlane
	{
		
	}
	public class Plane:CommonProperties
	{
		public byte EnginesCount { get; private set; }

		public Plane (int maxHeight,byte enginesCount):base(maxHeight)
		{
			enginesCount = EnginesCount;
		}

		public void WriteAllProperties()
		{
			Console.WriteLine($"{nameof(EnginesCount)}:{EnginesCount}" +
								$"{nameof(CurrentHeight)}:{CurrentHeight}" +
								$"{nameof(MaxHeight)}:{MaxHeight}");
		}
	}
}
