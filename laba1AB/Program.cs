using System;

namespace laba1AB
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(TranslatingNumbers.UniversalConverter("1a", 20, 10));
			Console.WriteLine(TranslatingNumbers.UniversalConverter("30", 10, 20));
			Console.WriteLine(TranslatingNumbers.FromBinaryToHex("10001011"));
			Console.WriteLine(TranslatingNumbers.FromOctalToBinary("235"));

			var number1 = new TwentiesSystem("4");
			var number2 = new TwentiesSystem("2");

			Console.WriteLine(number1 + number2);
			Console.WriteLine(number1 - number2);
			Console.WriteLine(number1 * number2);
			Console.WriteLine(number1 / number2);
		}
	}
}
