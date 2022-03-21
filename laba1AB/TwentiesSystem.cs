namespace laba1AB
{
	internal class TwentiesSystem
	{
		public string Number { get; set; }

		public TwentiesSystem(string number)
		{
			Number = number;
		}

		public static string operator +(TwentiesSystem counter1, TwentiesSystem counter2)
		{
			int decNumber1 = int.Parse(TranslatingNumbers.UniversalConverter(counter1.Number, 20, 10));
			int decNumber2 = int.Parse(TranslatingNumbers.UniversalConverter(counter2.Number, 20, 10));

			return TranslatingNumbers.UniversalConverter((decNumber1 + decNumber2).ToString(), 10, 20);
		}

		public static string operator -(TwentiesSystem counter1, TwentiesSystem counter2)
		{
			int decNumber1 = int.Parse(TranslatingNumbers.UniversalConverter(counter1.Number, 20, 10));
			int decNumber2 = int.Parse(TranslatingNumbers.UniversalConverter(counter2.Number, 20, 10));

			if (decNumber1 - decNumber2 < 0)
				(decNumber1, decNumber2) = (decNumber2, decNumber1);
			return "-" + TranslatingNumbers.UniversalConverter((decNumber1 - decNumber2).ToString(), 10, 20);
		}

		public static string operator *(TwentiesSystem counter1, TwentiesSystem counter2)
		{
			int decNumber1 = int.Parse(TranslatingNumbers.UniversalConverter(counter1.Number, 20, 10));
			int decNumber2 = int.Parse(TranslatingNumbers.UniversalConverter(counter2.Number, 20, 10));

			return TranslatingNumbers.UniversalConverter((decNumber1 * decNumber2).ToString(), 10, 20);
		}

		public static string operator /(TwentiesSystem counter1, TwentiesSystem counter2)
		{
			double decNumber1 = int.Parse(TranslatingNumbers.UniversalConverter(counter1.Number, 20, 10));
			double decNumber2 = int.Parse(TranslatingNumbers.UniversalConverter(counter2.Number, 20, 10));
			double decNumber3 = decNumber1 / decNumber2;
			int num2 = (int)decNumber3;
			int num = (int)((decNumber3 % 10) * 1000);

			if (num < 1)
				return TranslatingNumbers.UniversalConverter(num2.ToString(), 10, 20) + "." + TranslatingNumbers.UniversalConverter(num.ToString(), 10, 20);
			return TranslatingNumbers.UniversalConverter(num2.ToString(), 10, 20);
		}
	}
}
