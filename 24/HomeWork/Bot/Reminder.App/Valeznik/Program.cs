using Reminder.Storage.Core;
using Reminder.Storage.WebApi.Client;
using System;

namespace Valeznik
{
	class Program
	{
		static void Main(string[] args)
		{
			var client = new ReminderStorageWebApiClient("https://localhost:5001");
			var reminderItem = new ReminderItem
			{
				ContactId = "TestContactId",
				Date = DateTimeOffset.Now,
				Message = "Test"
			};
			client.Add(reminderItem);

			Console.WriteLine("f");

		}
	}
}
