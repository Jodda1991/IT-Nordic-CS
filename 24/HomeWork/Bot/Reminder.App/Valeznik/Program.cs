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
			var reminderItem = new ReminderItemRestricted
			{
				ContactId = "TestContactId",
				Date = DateTimeOffset.Now,
				Message = "Test"
			};
			Guid id = client.Add(reminderItem);

			Console.WriteLine("Adding done");

			var reminderItemFromStorage = client.Get(id);
			Console.WriteLine($"{reminderItemFromStorage.Id}\n" +
				$"{reminderItemFromStorage.ContactId}\n" +
				$"{reminderItemFromStorage.Date}\n" +
				$"{reminderItemFromStorage.Message}\n");
			
		}
	}
}
