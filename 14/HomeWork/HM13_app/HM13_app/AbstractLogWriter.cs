using System;
using System.Collections.Generic;
using System.Text;

namespace HM14_app
{
	public abstract class AbstractLogWriter:ILogWriter
	{
		private readonly string _logRecordFormat = "{0:yyyy-MM-ddThh:mm:ss}+0000\t{1}\t{2}";

		public void LogError(string message)
		{
			LogRecord(message, LogTypes.Error);
		}

		public void LogInfo(string message)
		{
			LogRecord(message, LogTypes.Info);
		}

		public void LogWarning(string message)
		{
			LogRecord(message, LogTypes.Warning);
		}

		protected string GetLogRecord(string message, LogTypes logRecordType)
		{
			return string.Format(
				_logRecordFormat,
				DateTime.UtcNow,
				logRecordType,
				message);
		}

		protected abstract void LogRecord(string message, LogTypes logRecordType);
	}
}
