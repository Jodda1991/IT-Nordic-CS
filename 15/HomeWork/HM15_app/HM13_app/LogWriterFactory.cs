using System;
using System.Collections.Generic;
using System.Text;

namespace HM13_app
{
	public class LogWriterFactory
	{
		private static LogWriterFactory instance;

		private LogWriterFactory()
		{ }

		public static LogWriterFactory GetInstance()
		{
			if (instance == null)
				instance = new LogWriterFactory();
			return instance;
		}
		public ILogWriter GetLogWriter<T>(object parameters = null) where T : ILogWriter
		{
			if (typeof(T) == typeof(ConsoleLogWriter))
				return new ConsoleLogWriter();
			if (typeof(T) == typeof(FileLogWriter))
				return new FileLogWriter();
			if (typeof(T) == typeof(MultipleLogWriter))
				return new MultipleLogWriter((List<ILogWriter>)parameters);
			else
				return null;	
		}
	}
}
