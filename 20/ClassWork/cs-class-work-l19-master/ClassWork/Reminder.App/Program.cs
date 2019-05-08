using System;
using Reminder.Domain;
using Reminder.Domain.EventArgs;
using Reminder.Receiver.Telegram;
using Reminder.Sender.Telegram;
using Reminder.Storage.InMemory;

namespace Reminder.App
{
	class Program
	{
		static void Main(string[] args)
		{
			const string token = "819772297:AAHTe4KKsAWIFznjuJ0-nTD1nzNim0HcZ8w";

			var receiver = new TelegramReminderReceiver(token);
			var sender = new TelegramReminderSender(token);
			var storage = new InMemoryReminderStorage();

			var domain = new ReminderDomain(
				storage,
				receiver,
				sender);


			domain.AddingSucceded += Domain_AddingSucceded;
			domain.SendingSucceded += Domain_SendingSucceded;
			domain.SendingFailed += Domain_SendingFailed;

			domain.Run();

			Console.ReadLine();
		}


		private static void Domain_AddingSucceded(
			object sender,
			AddingSuccededEventArgs e)
		{
			Console.WriteLine(
				$"Reminder from contact ID {e.Reminder.ContactId} " +
				$"with the message \"{e.Reminder.Message}\" " +
				$"successfully scheduled on {e.Reminder.Date:s}");
		}

		private static void Domain_SendingSucceded(
			object sender,
			SendingSuccededEventArgs e)
		{
			Console.WriteLine(
				"Reminder {0:N} successfully sent message text \"{1}\"",
				e.Reminder.Id,
				e.Reminder.Message);
		}

		private static void Domain_SendingFailed(object sender, SendingFailedEventArgs e)
		{
			Console.WriteLine(
				"Reminder {0:N} sending has failed. Exception:\n{1}",
				e.Reminder.Id,
				e.Exception);
		}

	}
}
