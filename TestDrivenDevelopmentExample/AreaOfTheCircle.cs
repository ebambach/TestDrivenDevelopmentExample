using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopmentExample {
	public class AreaOfTheCircle {
		private const double Pi = 3.14;
		public double Radius { get; set; }

		public double CalculateArea() {
			if (Radius <= 0) {
				throw new ArgumentOutOfRangeException("Radius must be greater than 0");
			}
			if ((Pi* (Radius * Radius)) >= double.MaxValue) {
				throw new ArgumentOutOfRangeException("Radius has exceeded the max value");
			}
			return (Pi * (Radius * Radius));
		}
	}
}
