using tlrt.Containers;

namespace trlt.Options
{
	class OptionsAnalyzer
	{
		string usr_option;
		ValidOptions valid_options;
		OptionsActivator activator;
		MessagesToUser messages;


		public OptionsAnalyzer(string _option)
		{
			usr_option = _option;
			valid_options = new ValidOptions();
			activator = new OptionsActivator();
			messages = new MessagesToUser();

		}

		bool IsValidOption()
		{
			foreach (Option _option in valid_options.GetValidOptions)
				if (usr_option == _option.ShortName || usr_option == _option.FullName)
					return true;
			return false;
		}

		public void OptionCheck()
		{
			// if (IsValidOption())
			// 	activator.ActivateOption();
		}
	}
}
