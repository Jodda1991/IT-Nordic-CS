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
			byte[] arr = data;
			float percent = percentageToFireEvent;
			percent = 0.1F;
			while (percent < 100)
			{
				for (int i = 0; i < 100; i++)
				{
					percent = percent * 100;
				}
				break;
			}
			Console.ReadLine();
		}
	}
}
