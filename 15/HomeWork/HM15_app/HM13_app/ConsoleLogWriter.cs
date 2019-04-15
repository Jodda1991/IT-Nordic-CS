using System;
using System.Collections.Generic;
using System.Text;

namespace HM13_app
{
	public class ConsoleLogWriter: AbstractLogWriter, ILogWriter
	{

		protected override void LogRecord(string message, LogTypes logTypes)
		{
			Console.WriteLine(base.GetLogRecord(message, logTypes));
		}
	}
}
