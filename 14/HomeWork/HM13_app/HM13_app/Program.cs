using System;

namespace HM14_app
{
	class Program
	{
		static void Main(string[] args)
		{
			ConsoleLogWriter demo =ConsoleLogWriter.GetSingle();

			var fileLogger = new FileLogWriter();

			using (var logger = new MultipleLogWriter(demo, fileLogger))
			{
				logger.LogInfo("Test information message");
				logger.LogWarning("Test warning message");
				logger.LogError("Test error message");
			}
		}
	}
}
