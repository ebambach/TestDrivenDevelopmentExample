using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDrivenDevelopmentExample;

namespace TestSuiteAreaOfACircle {
	//This test class poses a variety of situations that we want to test
	//before we say, "This program is ready to go."  Over the course of this
	//exercise, we successfully set up tests for if the radius is -1, 1, 2, 0,
	//and the min Double value.
	//We attempted to set up a test for the max Double value, but we did not complete
	//this during class (we would need to go back to the AreaOfTheCircle class, and
	//set up an ArgumentOutOfRangeException for a radius that would result in
	//an area >= the max Double value).
	[TestClass]
	public class TestAreaOfACircle {
		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void TestForZero() {
			AreaOfTheCircle circle = new AreaOfTheCircle();
			circle.Radius = 0;
			var area = circle.CalculateArea();
			Assert.Fail();
		}
		[TestMethod]
		public void TestForOne() {
			AreaOfTheCircle circle = new AreaOfTheCircle();
			circle.Radius = 1;
			var area = circle.CalculateArea();
			Assert.AreEqual(3.14, area, "R=3.14");
		}
		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void TestForNegOne() {
			AreaOfTheCircle circle = new AreaOfTheCircle();
			circle.Radius = -1;
			var area = circle.CalculateArea();
			Assert.Fail();
		}
		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void TestForMaxValue() {
			//1.8 × 10308
			AreaOfTheCircle circle = new AreaOfTheCircle();
			circle.Radius = double.MaxValue;
			var area = circle.CalculateArea();
			Assert.Fail();
		}
		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void TestForMinValue() {
			AreaOfTheCircle circle = new AreaOfTheCircle();
			circle.Radius = double.MinValue;
			var area = circle.CalculateArea();
			Assert.Fail();
		}
		[TestMethod]
		public void TestForTwo() {
			AreaOfTheCircle circle = new AreaOfTheCircle();
			circle.Radius = 2;
			var area = circle.CalculateArea();
			Assert.AreEqual(12.56, area, "R=1");
		}

	}
}
