using System;
using System.Collections.Generic;
using System.Text;

namespace CW17_SW
{
	class RandomDataEventArgs:EventArgs
	{
		public int bytesDone { get; set; }
		public int totalBytes { get; set; }

		public RandomDataEventArgs (int _bytesDone,int _totalBytes)
		{
			bytesDone = _bytesDone;
			totalBytes = _totalBytes;
		}
	}
}
