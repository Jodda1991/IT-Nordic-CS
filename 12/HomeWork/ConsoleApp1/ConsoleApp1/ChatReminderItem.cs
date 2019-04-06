using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	public class ChatReminderItem:ReminderItem
	{
		public string ChatName { get; set; }

		public string AccountName { get; set; }

		public ChatReminderItem(DateTimeOffset alarmDate, string alarmMassage, string chatName , string accountName): base(alarmDate, alarmMassage)
		{
			ChatName = chatName;
			AccountName = accountName;
		}

		public override void WriteProperties()
		{
			Console.WriteLine($"{GetType().Name}" +
				$"\n Your alarm was set on {AlarmDate.ToString("MM/dd/yyyy HH:mm:ss")}" +
				$"\n with message: {AlarmMessage}\n chat name: {ChatName} " +
				$"\n account name: {AccountName} ");
		}
	}
}
