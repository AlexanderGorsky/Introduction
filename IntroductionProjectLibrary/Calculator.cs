using System;

namespace IntroductionProjectLibrary
{
	public class Calculator
	{
		private int firstNumber;
		private int secondNumber;

		public Calculator(int firstNumber, int secondNumber)
		{
			this.firstNumber = firstNumber;
			this.secondNumber = secondNumber;
		}

		public int Sum()
		{
			int result = firstNumber + secondNumber;
			return result;
		}

		public int Multiply()
		{
			int result = firstNumber * secondNumber;
			return result;
		}

		public double Divide()
		{
			if (secondNumber == 0)
			{
				throw new DivideByZeroException();
			}
			double result = (double)firstNumber / secondNumber;
			return result;
		}
		
		public int Deduction()
		{
			int result = firstNumber - secondNumber;
			return result;
		}
	}
}
