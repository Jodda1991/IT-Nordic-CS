using System;
using System.Collections.Generic;
using System.Text;

namespace HM14_app
{
	public class ConsoleLogWriter: AbstractLogWriter, ILogWriter
	{
		private static ConsoleLogWriter single = Console.WriteLine(base.GetLogRecord(message, logTypes));

		private  ConsoleLogWriter()
		{

		}

		public static ConsoleLogWriter GetSingle()
		{
			if(single ==null)
			{
				single = new ConsoleLogWriter();
				
				
			}
			return single;
		}
		protected override void LogRecord(string message, LogTypes logTypes)
		{
			Console.WriteLine(base.GetLogRecord(message, logTypes));
		}
	}
}
