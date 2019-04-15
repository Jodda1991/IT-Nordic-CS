using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HM13_app
{//
	class FileLogWriter: AbstractLogWriter, ILogWriter, IDisposable
	{
		private StreamWriter _logFileWriter;

		public FileLogWriter(string fileName = "log.txt")
		{
			_logFileWriter = new StreamWriter(
				File.Open(
					fileName,
					FileMode.OpenOrCreate,
					FileAccess.ReadWrite,
					FileShare.Read));

			_logFileWriter.BaseStream.Seek(0, SeekOrigin.End);
		}

		protected override void LogRecord(string message, LogTypes logTypes)
		{
			string logRecord = base.GetLogRecord(message, logTypes);
			_logFileWriter.WriteLine(logRecord);
			_logFileWriter.Flush();
		}

		public void Dispose()
		{

			if (_logFileWriter != null)
				_logFileWriter.Dispose();
		}
	}
}
