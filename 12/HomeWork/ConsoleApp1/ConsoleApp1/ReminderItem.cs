using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	public class ReminderItem
	{
		public DateTimeOffset AlarmDate { get; set; }

		public string AlarmMessage { get; set; }

		public TimeSpan TimeToAlarm
		{
			get {return AlarmDate.Subtract(DateTimeOffset.UtcNow);}
		}

		public bool IsOutdated
		{
			get {
				return TimeToAlarm >= TimeSpan.Zero
				   ? true
				   : false;
			}
		}

		public ReminderItem (DateTimeOffset alarmDate,string alarmMessage)
		{
			AlarmDate = alarmDate;
			AlarmMessage = alarmMessage;
		}

		public virtual void WriteProperties()
		{
			Console.WriteLine($"{ GetType().Name}\n Your alarm was set on " +
				$"{ AlarmDate.ToString("MM/dd/yyyy HH:mm:ss")}" +
				$"\n with message: {AlarmMessage}" +
				$"\n time before alarm you have: {TimeToAlarm.ToString()}" +
				$"\n {nameof(IsOutdated)}:{IsOutdated}");
		}
	}
}
