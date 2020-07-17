using System;
using trlt.Containers;

namespace trlt.Options
{
	class OptionsActivator
	{
		ValidOptions valid_option;
		UserMessagesSender msg;

		string ver, utility_name, author, github;

		public OptionsActivator()
		{
			valid_option = new ValidOptions();
			msg = new UserMessagesSender();

			ver = "v1.0";
			utility_name = "trlt";
			author = "CIRCULARKA";
			github = "https://github.com/CIRCULARKA/trlt";
		}

		public void ActivateOption(string name)
		{
			if (name == valid_option.GetOption(OptionName.HelpOption))
			{
				msg.ShowLogMsg("This program allows you to transliterate filenames or strings from cyrillic to english."
					+ "\n\nUse:\ntrlt [option] [value].\nAvailable options:\n");
				foreach (Option op in valid_option.GetValidOptions)
					Console.WriteLine($"\t{op.ShortName}\t{op.FullName}\t{op.Description}");
			}
			else if (name == valid_option.GetOption(OptionName.VerOption))
			{
				msg.ShowLogMsg($"{utility_name} {ver}. Author: CIRCULARKA.\n" +
					$"Github: {github}.");
			}
		}
	}
}
