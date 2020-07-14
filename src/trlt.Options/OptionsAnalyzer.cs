namespace trlt.Options
{
	class OptionsAnalyzer
	{
		string[] args;
		ValidOptions valid_options;
		OptionsActivator activate;

		public OptionsAnalyzer(string[] _args)
		{
			args = _args;
			valid_options = new ValidOptions();
			activate = new OptionsActivator();

		}

		bool IsValidOption(string _option)
		{
			foreach (Option option in valid_options.GetValidOptions)
				if (_option == option.ShortName || _option == option.FullName)
					return true;
			return false;
		}

		public void CheckForOptions()
		{
			foreach (string arg in args)
			{

			}
		}
	}
}
