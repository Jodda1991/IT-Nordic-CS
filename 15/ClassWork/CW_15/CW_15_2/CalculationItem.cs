using System;
using System.Collections.Generic;
using System.Text;

namespace CW_15_2
{
	public class CalculationItem
	{
		public double CalculateSquare(double radius)
		{
			
			 return Math.PI * Math.Pow(radius, 2);
			 
		}

		public double CalculatePerimeter(double radius)
		{
			return 2 * Math.PI * radius;
		}

	}
}
