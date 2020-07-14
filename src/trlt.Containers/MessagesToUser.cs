using System;

namespace tlrt.Containers
{
	class MessagesToUser
	{
		public void ShowSuccessMsg(string value)
        {
            ConsoleColor native_color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(value);
            Console.ForegroundColor = native_color;
        }

		public void ShowErrMsg(string value)
        {
            ConsoleColor native_color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(value);
            Console.ForegroundColor = native_color;
        }

		 public void ShowLogMsg(string value)
        {
            Console.WriteLine(value);
        }
	}
}
