using System;

namespace Reminder.Domain.Model
{
	public class AddReminderModel
	{
		public DateTimeOffset Date { get; set; }

		public string ContactId { get; set; }

		public string Message { get; set; }

	}
}