using System;
using System.Collections.Generic;
using System.Text;

namespace HM13_app
{
	class MultipleLogWriter:AbstractLogWriter,ILogWriter,IDisposable
	{
		private IEnumerable<ILogWriter> _logWriters;

		public MultipleLogWriter(List<ILogWriter> writers)
		{
			_logWriters = writers;
		}

		protected override void LogRecord(string message, LogTypes logTypes)
		{
			string logRecord = base.GetLogRecord(message, logTypes);

			foreach (var writer in _logWriters)
			{
				switch (logTypes)
				{
					case LogTypes.Info:
						writer.LogInfo(message);
						break;
					case LogTypes.Warning:
						writer.LogWarning(message);
						break;
					case LogTypes.Error:
						writer.LogError(message);
						break;
				}
			}
		}

		public void Dispose()
		{
			foreach (var writer in _logWriters)
			{
				if (writer is IDisposable && writer != null)
				{
					((IDisposable)writer).Dispose();
				}
			}
		}
	}
}
