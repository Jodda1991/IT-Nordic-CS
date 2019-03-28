using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	class ReminderItem
	{
		public DateTimeOffset AlarmDate { get; set; }

		public string AlarmMessage { get; set; }

		public int TimeToAlarm
		{
			get { TimeSpan timeForSleep = AlarmDate -DateTimeOffset.UtcNow;
				return Convert.ToInt32(timeForSleep.TotalMinutes); }
		}

		public bool IsOutdated
		{
			get {
				bool youHaveATime=true;
				if (TimeToAlarm>=0)
				{
					youHaveATime = true;
				}
				else if(TimeToAlarm<0)
				{
					youHaveATime = false;
				}
				return youHaveATime;
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

			Console.WriteLine($"Your alarm was set on {AlarmDate}\n with message: {AlarmMessage}\n and {inTimeOrLate} : ({TimeToAlarm} minutes)");
		}






	}
}
