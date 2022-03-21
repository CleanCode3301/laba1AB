using System;

namespace laba1AB
{
	internal class TranslatingNumbers
	{
		public static string UniversalConverter(string number, int FromBase, int ToBase)
		{
			string r = "";
			string letter = "0123456789abcdefghij";
			number = number.ToLower();
			int temp10 = 0;
			for (int i = 0; i < number.Length; i++)
			{
				int x = letter.IndexOf(number[i]);
				if (x == -1) throw new Exception(" + number +  числом не является");
				temp10 += x * (int)Math.Pow(FromBase, number.Length - i - 1);
			}
			while (temp10 >= ToBase)
			{
				int mod = temp10 % ToBase;
				r = r.Insert(0, letter[mod].ToString());
				temp10 /= ToBase;
			}
			r = r.Insert(0, letter[temp10].ToString());
			return r;
		}

		public static (string, string) FromBinaryToHex(string binNumber)
			=> (UniversalConverter(binNumber, 2, 2), UniversalConverter(binNumber, 2, 16));

		public static string FromOctalToBinary(string octNumber)
			=> UniversalConverter(octNumber, 16, 2);
	}
}
