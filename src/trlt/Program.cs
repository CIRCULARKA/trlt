using System;
using System.IO;
using tlrt.Containers;

namespace trlt
{
	class Program
	{
		static string TrltString(string value)
		{
			LettersTable table = new LettersTable();
			string result = "";
			foreach (var item in value)
				result += table.GetTransliteration(item.ToString());

			return result;
		}

		static void Main(string[] args)
		{
			var messages = new MessagesToUser();

			const int OPTION_POS = 1, VALUE_POS = 0;


			if (args.Length == 2)
			{
				try
				{
                    // Firstly - attempt to rename file
					try
					{
						FileInfo file = new FileInfo(args[VALUE_POS]);
						file.MoveTo(file.DirectoryName + "/" + TrltString(file.Name));
                       messages.ShowSuccessMsg("File transliterated successfully.");
					}
                    // Plan B - attempt to rename all files in directory
					catch (FileNotFoundException)
					{
						var dir = new DirectoryInfo(args[VALUE_POS]);
						FileInfo[] files = dir.GetFiles();
						messages.ShowLogMsg("Processing...");
						for (int j = 0; j < files.Length; j++)
							files[j].MoveTo(files[j].DirectoryName + "/" + TrltString(files[j].Name));
                        messages.ShowSuccessMsg("All files in specified directory transliterated successfully.");
					}
				}
                // Plan C - if specified directory or file wasn't found the program return transliterated string
				catch (DirectoryNotFoundException)
				{
					Console.WriteLine(TrltString(args[VALUE_POS]));
				}
				catch
				{
					messages.ShowErrMsg("Unexpected error.");
				}
			}
		}
	}
}
