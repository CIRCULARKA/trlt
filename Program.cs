using System;
using System.IO;

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


        static void ShowSuccessMsg(string value)
        {
            ConsoleColor native_color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(value);
            Console.ForegroundColor = native_color;
        }

        static void ShowLogMsg(string value)
        {
            Console.WriteLine(value);
        }

        static void ShowErrMsg(string value)
        {
            ConsoleColor native_color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(value);
            Console.ForegroundColor = native_color;
        }

		static void Main(string[] args)
		{
            // Proceed all args
			for (int i = 0; i < args.Length; i++)
			{
				Console.Write((i + 1) + ": ");
				try
				{
                    // Firstly - attempt to rename file
					try
					{
						FileInfo file = new FileInfo(args[i]);
						file.MoveTo(file.DirectoryName + "/" + TrltString(file.Name));
                       ShowSuccessMsg("File transliterated successfully.");
					}
                    // Plan B - attempt to rename all files in directory
					catch (FileNotFoundException)
					{
						var dir = new DirectoryInfo(args[i]);
						FileInfo[] files = dir.GetFiles();
						ShowLogMsg("Processing...");
						for (int j = 0; j < files.Length; j++)
							files[j].MoveTo(files[j].DirectoryName + "/" + TrltString(files[j].Name));
                        ShowSuccessMsg("All files in specified directory transliterated successfully.");
					}
				}
                // Plan C - if specified directory or file wasn't found the program return transliterated string
				catch (DirectoryNotFoundException)
				{
					ShowLogMsg("Specified file/directory not found. Instead of it here is your string:");
					Console.WriteLine(TrltString(args[i]));
				}
				catch
				{
					ShowErrMsg("Unexpected error.");
				}
			}
		}
	}
}
