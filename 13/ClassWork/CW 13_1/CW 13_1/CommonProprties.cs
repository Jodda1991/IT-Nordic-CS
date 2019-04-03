using System;
using System.Collections.Generic;
using System.Text;

namespace CW_13_1
{
	public abstract class CommonProperties
	{
		public int MaxHeight { get; private set; }

		public int CurrentHeight { get; private set; }

		public void TakeUpper(int delta)
		{
			if(0>=delta)
			{
				throw new ArgumentOutOfRangeException();
			}
			else if(CurrentHeight+delta>MaxHeight) 
			{
				CurrentHeight = MaxHeight;
			}
			else
			{
				CurrentHeight = CurrentHeight + delta;
			}
		}

		public CommonProperties(int maxHeight)
		{
			maxHeight = MaxHeight;
			CurrentHeight = 0;
		}

		public void TakeLower(int delta)
		{
			int newHeight;
			if(0>=delta)
			{
				throw new ArgumentOutOfRangeException();
			}
			else if (CurrentHeight-delta>0)
			{
				 newHeight= CurrentHeight - delta;
				CurrentHeight = newHeight;
			}
			else if (CurrentHeight-delta ==0)
			{
				CurrentHeight = 0;
			}
			else if(0>delta)
			{
				throw new InvalidOperationException("Crash!");
			}
		}
	}
}
