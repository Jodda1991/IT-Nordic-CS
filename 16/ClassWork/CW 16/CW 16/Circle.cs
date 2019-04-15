using System;
using System.Collections.Generic;
using System.Text;

namespace CW_16
{
	class Circle
	{
		private double _radius;

		public Circle(double radius)
		{
			_radius = radius;
		}

		public double Calculate(Func<double, double> operation)
		{
			return operation(_radius);
		}
	}
}
