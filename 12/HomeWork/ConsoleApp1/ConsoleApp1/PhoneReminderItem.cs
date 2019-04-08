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
			base.WriteProperties();
			Console.WriteLine($" phone number: {PhoneNumber} ");
		}
	}
}
