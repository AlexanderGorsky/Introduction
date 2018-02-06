using System;
using IntroductionProjectLibrary;
using System.IO;

namespace IntroductionProjectConsole
{
	public class Inputer
	{
		public int InputInt()
		{
			int result = 0;
			try
			{
				result = Int32.Parse(Console.ReadLine());
			}
			catch (FormatException ex)
			{
				Console.WriteLine(ex.Message);
			}
			return result;
		}

		public int[] StringToIntArr()
		{
			string str = ReadFromConfFile();
			string[] stringFromConfig = str.Split('|');
			int[] numbersFromConfig = Array.ConvertAll<string, int>(stringFromConfig, int.Parse);
			return numbersFromConfig;
		}

		public string ReadFromConfFile() 
		{
			string stringFromConfig = string.Empty;
			using (StreamReader sr = new StreamReader("config.txt")) {
			stringFromConfig = sr.ReadLine();
		}
			return stringFromConfig;
		}
	}
}
