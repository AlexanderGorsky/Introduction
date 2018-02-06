using System;
using NUnit.Framework;
using IntroductionProjectLibrary;

namespace IntroductionProjectTests
{
	[TestFixture]
	public class InputerTests
	{
		private static object[] positiveTestCases =
		{
			new object[] { 0, 1, 0},
			new object[] { -1, 1, -1/1},
			new object[] {123, 123, 123/123},
			new object[] {-9, -6, 1.5},
			new object[] {-9, 6, -1.5},
		};

		private static object[] negativeTestCases =
		{
			new object[] { int.MaxValue, 1, 0},
		};

		[Test]
		[Category("Positive"), TestCaseSource("positiveTestCases")]
		public void PositiveDivideTests(int firstVal, int secVal, double result)
		{
			Calculator calc = new Calculator(firstVal, secVal);
			Assert.AreEqual(calc.Divide(), result);
		}

		[Test]
		public void DivideByZero()
		{
			Calculator calc = new Calculator(1, 0);
			Assert.Throws<DivideByZeroException>(() => calc.Divide());
		}

	}
}
