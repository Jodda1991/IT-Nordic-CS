using System;
using System.Collections.Generic;

namespace HM13_app
{
	class Program
	{
		static void Main(string[] args)
		{
			LogWriterFactory factory = LogWriterFactory.GetInstance();

			var consoleLogwriter = (ConsoleLogWriter)factory.GetLogWriter<ConsoleLogWriter>();
			var fileLogwriter = (FileLogWriter)factory.GetLogWriter<FileLogWriter>();
			var multipleLogwriter = factory.GetLogWriter<MultipleLogWriter>(new List<ILogWriter> { consoleLogwriter, fileLogwriter });

			multipleLogwriter.LogInfo("Test information messege 0017890");
			multipleLogwriter.LogWarning("Test warning messege 0216637");
			multipleLogwriter.LogError("Test error messege 1184225");

			Console.ReadLine();
		}
	}
}
