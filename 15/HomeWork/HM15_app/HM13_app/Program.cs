using System;
using System.Collections.Generic;

namespace HM13_app
{
	class Program
	{
		static void Main(string[] args)
		{
			LogWriterFactory factory = LogWriterFactory.GetInstance();

			var consoleLogWriter = (ConsoleLogWriter)factory.GetLogWriter<ConsoleLogWriter>();
			var fileLogWriter = (FileLogWriter)factory.GetLogWriter<FileLogWriter>();
			var multipleLogWriter = factory.GetLogWriter<MultipleLogWriter>(new List<ILogWriter> { consoleLogWriter, fileLogWriter });

			multipleLogWriter.LogInfo("Test information messege 0017890");
			multipleLogWriter.LogWarning("Test warning messege 0216637");
			multipleLogWriter.LogError("Test error messege 1184225");

		}
	}
}
