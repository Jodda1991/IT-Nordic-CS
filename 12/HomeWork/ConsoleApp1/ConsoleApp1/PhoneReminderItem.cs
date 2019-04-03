using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	public class PhoneReminderItem:ReminderItem
	{

		public string PhoneNumber { get; set; }

		public PhoneReminderItem(DateTimeOffset alarmDate, string alarmMessage, string phoneNumber):base(alarmDate,alarmMessage)
		{
			PhoneNumber = phoneNumber;
		}

		public override void WriteProperties ()
		{
			Console.WriteLine($"{GetType().Name}\n Your alarm was set on {AlarmDate.ToString("MM/dd/yyyy HH:mm:ss")}\n with message: {AlarmMessage}\n phone number: {PhoneNumber} ");
		}
	}
}
