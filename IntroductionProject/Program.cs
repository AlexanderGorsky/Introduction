using System;
using IntroductionProjectLibrary;
using System.Configuration;

namespace IntroductionProjectConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			Inputer inputer = new Inputer();
			ChooserInputType();
			string choose = ConfigurationManager.AppSettings.Get("InputType");
			switch (choose)
			{
				case "console":
					{
						Console.WriteLine("In case of the first task you need to enter 2 integer numbers to sum them");
						Calculator calcFromConsole = new Calculator(inputer.InputInt(), inputer.InputInt());
						Console.Clear();
						Console.WriteLine($"Sum is: {calcFromConsole.Sum()}");
						Console.WriteLine($"Division is: {calcFromConsole.Divide()}");
						Console.WriteLine($"Multiply is: {calcFromConsole.Multiply()}");
						Console.WriteLine($"Deduction is: {calcFromConsole.Deduction()}");
						break;
					}

				case "file":
					{
						Console.Clear();
						Console.WriteLine("Result from file data:\n");
						Calculator calcFromFile = new Calculator(inputer.StringToIntArr()[0], inputer.StringToIntArr()[1]);
						Console.WriteLine($"Sum is: {calcFromFile.Sum()}");
						Console.WriteLine($"Division is: {calcFromFile.Divide()}");
						Console.WriteLine($"Multiply is: {calcFromFile.Multiply()}");
						Console.WriteLine($"Deduction is: {calcFromFile.Deduction()}");
						break;
					}
				default:
					{
						Console.WriteLine("I don't know how you crashed this =(");
						break;
					}
			}

		}

		public static void ChooserInputType()
		{
			Console.WriteLine("What do you want to use to get two numbers?\n1. Console\n2. File");
			string choose = Console.ReadLine();
			switch (choose)
			{
				case "1":
					{
						ConfigurationManager.AppSettings.Set("InputType", "console");
						break;
					}

				case "2":
					{
						ConfigurationManager.AppSettings.Set("InputType", "file");
						break;
					}

				default:
					{
						Console.WriteLine("Incorrect input. Try again later.");
						break;
					}
			}
		}
	}
}
