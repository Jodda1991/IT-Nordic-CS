using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	class ReminderItem
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

		public void WriteProperties()
		{
			string inTimeOrLate;
			if(IsOutdated)
			{
				inTimeOrLate = "you have some time";
			}
			else
			{
				inTimeOrLate = "you have no time!";
			}

			Console.WriteLine($"Your alarm was set on {AlarmDate}\n with message: {AlarmMessage}\n and {inTimeOrLate} ");
		}
	}
}
