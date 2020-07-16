namespace trlt.Options
{
	class ValidOptions
	{
		// Don't forget to add option at OptionName enum in the same order
		public Option[] GetValidOptions =>
			new Option[]
			{
				new Option("-h", "--help", "Show this help."),
				new Option("-V", "--Version", "Show application version."),
				new Option("-s", "--repl-spaces", "Replace spaces with underscores."),
				new Option("-r", "--recursive", "Transliterate all files in directory recursively."),
				new Option(".", "", "Transliterate all files in current directory."),
				new Option("..", "", "Transliterate all files in upper directory.")
			};

		public Option GetOption(OptionName name)
		{
			return GetValidOptions[(int)name];
		}
	}
}
