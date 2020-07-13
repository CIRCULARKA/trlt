namespace trlt.Options
{
	class Option
	{
		public Option(string _short, string full, string description)
		{
			ShortName = _short;
			FullName = full;
			Description = description;
		}

		public string ShortName { get; private set; }
		public string FullName { get; private set; }
		public string Description { get; private set; }

	}
}
