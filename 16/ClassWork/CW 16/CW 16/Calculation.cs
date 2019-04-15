using System;
using System.Collections.Generic;
using System.Text;

namespace CW_16
{
	class Calculation
	{
		int[] _array;

		public Calculation(int[]array)
		{
			_array = array;
		}

		public int CalcSingleValue(Func<int[],int>func)
		{
			return func(_array);
		}
	}

}
