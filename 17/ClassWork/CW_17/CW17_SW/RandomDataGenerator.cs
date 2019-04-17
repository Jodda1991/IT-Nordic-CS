using System;
using System.Collections.Generic;
using System.Text;

namespace CW17_SW
{
	

	


	class RandomDataGenerator
	{
		public event EventHandler<RandomDataEventArgs> RandomDataGenerated;

		public event EventHandler<RandomDataGenerationDoneArgs> RandomDataGenerationDone;
		public byte[] GetRandomData(int dataSize, int bytesDoneToRaiseEvent)
		{
			byte[] byteArray = new byte[dataSize];
			Random rand = new Random();
			for (int i = 0; i < dataSize; i++)
			{
				int random = rand.Next(256);
				byteArray[i] = (byte)random;
				if ((i + 1) % bytesDoneToRaiseEvent == 0)
				{
					OnRandomGenerated(this, new RandomDataEventArgs(i + 1, dataSize));
				}

			}
			OnRandomDone(this, new RandomDataGenerationDoneArgs{RandomDate = byteArray});
			return byteArray;
		}

		protected virtual void OnRandomGenerated(object sender , RandomDataEventArgs e)
		{
			if(RandomDataGenerated!=null)
			RandomDataGenerated(sender, e);
		}

		protected virtual void OnRandomDone(object sender, RandomDataGenerationDoneArgs e)
		{
			RandomDataGenerationDone?.Invoke(sender, e);
		}
	}
}
