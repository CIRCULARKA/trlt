using tlrt.Containers;

namespace trlt.Options
{
	class OptionsAnalyzer
	{
		string[] args;
		ValidOptions valid_options;
		OptionsActivator activate;
		MessagesToUser messages;


		public OptionsAnalyzer(string[] _args)
		{
			args = _args;
			valid_options = new ValidOptions();
			activate = new OptionsActivator();
			messages = new MessagesToUser();

		}

		bool IsValidOption(string _option)
		{
			foreach (Option option in valid_options.GetValidOptions)
				if (_option == option.ShortName || _option == option.FullName)
					return true;
			return false;
		}

		public void OptionCheck()
		{
			foreach (string arg in args)
			{
				// if (IsValidOption(arg))
					// activate
			}
		}
	}
}
