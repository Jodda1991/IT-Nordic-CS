using System;
using System.Collections.Generic;
using System.Text;

namespace HM
{
	class FileWriterWithProgress
	{
		public event EventHandler<WritingCompletedArgs> WritingCompleted;

		public event EventHandler<WritingPerformedArgs> WritingPerfomed;

		public void WriteBytes(string fileName, byte[] data, float percentageToFireEvent )
		{

		}
	}
}
