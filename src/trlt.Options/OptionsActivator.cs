using trlt.Containers;

namespace trlt.Options
{
	class OptionsActivator
	{
		ValidOptions valid_option;
		UserMessagesSender msg;

		public OptionsActivator()
		{
			valid_option = new ValidOptions();
			msg = new UserMessagesSender();
		}

		public void ActivateOption(string name)
		{
			if (name == valid_option.GetOption(OptionName.HelpOption).FullName |
				name == valid_option.GetOption(OptionName.HelpOption).FullName)
			{
				msg.ShowLogMsg("This program allows you to transliterate filenames or strings from cyrillic to english."
					+ "\n\nUse:\ntrlt [option] [value]");
			}
		}
	}
}
