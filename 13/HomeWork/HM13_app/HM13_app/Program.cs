using System;

namespace HM13_app
{
	class Program
	{
		static void Main(string[] args)
		{
			var consoleLogger = new ConsoleLogWriter();
			consoleLogger.LogWarning("test");

			var fileLogger = new FileLogWriter();

			using (var logger = new MultipleLogWriter(consoleLogger, fileLogger))
			{
				logger.LogInfo("Test information message");
				logger.LogWarning("Test warning message");
				logger.LogError("Test error message");
			}
		}
	}
}
