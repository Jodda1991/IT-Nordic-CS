using System;

namespace Reminder.Domain.Model
{
	/// <summary>
	/// The single reminder item.
	/// </summary>
	public class SendReminderModel
	{
		/// <summary>
		/// Gets the identifier.
		/// </summary>
		public Guid Id { get; set; } 

		/// <summary>
		/// Gets or sets the date and time the reminder item scheduled for sending.
		/// </summary>

		/// <summary>
		/// Gets or sets contact identifier in the target sending system
		/// </summary>
		public string ContactId { get; set; }
		/// <summary>
		/// The message of the reminder item for sending to the recepient.
		/// </summary>
		public string Message { get; set; }

		/// <summary>
		/// The identifier of the recepient.
		/// </summary>

		/// <summary>
		/// Gets the time before the message should be sent to the recepient.
		/// </summary>
	}
}

