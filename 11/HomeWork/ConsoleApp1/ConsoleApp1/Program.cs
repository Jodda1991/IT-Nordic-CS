using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			ReminderItem reminder = new ReminderItem();
			reminder.AlarmDate = DateTimeOffset.Parse("2019-04-02 12:30");
			reminder.AlarmMessage = "Important meeting";
			reminder.WriteProperties();

			ReminderItem reminder1 = new ReminderItem();
			reminder1.AlarmDate = DateTimeOffset.Parse("2019-03-27 19:40");
			reminder1.AlarmMessage = "Don't forget potatoes in the oven!";
			reminder1.WriteProperties();
		}
	}
}
