using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			ReminderItem reminder = new ReminderItem(DateTimeOffset.Parse("04-04-2019 5:00"), "Wake up");
			ReminderItem phoneReminder = new PhoneReminderItem(DateTimeOffset.Parse("05-02-2019 7:00"), "Call employer", "+7(912)8084532");
			ReminderItem chatReminder = new ChatReminderItem(DateTimeOffset.Parse("09-02-2019 12:30"), "Ask about project", "Nd1280", "Alex");

			var listReminder = new List<ReminderItem>
			{
				reminder,
				phoneReminder,
				chatReminder
			};

			foreach(var remind in listReminder)
			{
				remind.WriteProperties();
			}

			Console.ReadLine();
		}
	}
}
