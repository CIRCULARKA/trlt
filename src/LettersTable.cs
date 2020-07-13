using System.Collections.Generic;

namespace trlt
{
	class LettersTable
	{
		Dictionary<string, string> table;

		public LettersTable()
		{
			table = new Dictionary<string, string>();

			table.Add("А", "A");
			table.Add("Б", "B");
			table.Add("В", "V");
			table.Add("Г", "G");
			table.Add("Д", "D");
			table.Add("Е", "E");
			table.Add("Ё", "E");
			table.Add("Ж", "ZH");
			table.Add("З", "Z");
			table.Add("И", "I");
			table.Add("Й", "J");
			table.Add("К", "K");
			table.Add("Л", "L");
			table.Add("М", "M");
			table.Add("Н", "N");
			table.Add("О", "O");
			table.Add("П", "P");
			table.Add("Р", "R");
			table.Add("С", "S");
			table.Add("Т", "T");
			table.Add("У", "U");
			table.Add("Ф", "F");
			table.Add("Х", "KH");
			table.Add("Ц", "TS");
			table.Add("Ч", "CH");
			table.Add("Ш", "SH");
			table.Add("Щ", "SHCH");
			table.Add("Ъ", "\'\'");
			table.Add("Ы", "Y");
			table.Add("Ь", "\'");
			table.Add("Э", "EH");
			table.Add("Ю", "YU");
			table.Add("Я", "YA");

			table.Add("а", "a");
			table.Add("б", "b");
			table.Add("в", "v");
			table.Add("г", "g");
			table.Add("д", "d");
			table.Add("е", "e");
			table.Add("ё", "e");
			table.Add("ж", "zh");
			table.Add("з", "z");
			table.Add("и", "i");
			table.Add("й", "j");
			table.Add("к", "k");
			table.Add("л", "l");
			table.Add("м", "m");
			table.Add("н", "n");
			table.Add("о", "o");
			table.Add("п", "p");
			table.Add("р", "r");
			table.Add("с", "s");
			table.Add("т", "t");
			table.Add("у", "u");
			table.Add("ф", "f");
			table.Add("х", "kh");
			table.Add("ц", "ts");
			table.Add("ч", "ch");
			table.Add("ш", "sh");
			table.Add("щ", "shch");
			table.Add("ъ", "\'\'");
			table.Add("ы", "y");
			table.Add("ь", "\'");
			table.Add("э", "eh");
			table.Add("ю", "yu");
			table.Add("я", "ya");
		}

		public string GetTransliteration(string value)
		{
			try
			{
				return table[value];
			}
			catch (KeyNotFoundException)
			{
				return value;
			}
		}
	}
}
