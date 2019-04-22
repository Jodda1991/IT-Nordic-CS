using System;
using System.Collections.Generic;
using System.Text;

namespace HM
{
	public class WritingPerformedArgs:EventArgs
	{
		public byte[] data;

		public float percentageToFireEvent;
	}
}
