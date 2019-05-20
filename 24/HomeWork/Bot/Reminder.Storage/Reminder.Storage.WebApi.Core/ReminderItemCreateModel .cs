using Reminder.Storage.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Reminder.Storage.WebApi.Core
{
	public class ReminderItemCreateModel
	{
		[Required]
		public DateTimeOffset Date { get; set; }

		/// <summary>
		/// Gets or sets contact identifier in the target sending system.
		/// </summary>
		[Required]
		[MaxLength(50)]
		public string ContactId { get; set; }

		/// <summary>
		/// Gets or sets the message of the reminder item for sending to the recipient.
		/// </summary>
		[Required]
		[MaxLength(200)]
		public string Message { get; set; }

		/// <summary>
		/// Gets or sets the identifier of the recipient.
		[Required]
		[Range(0,3)]
		public ReminderItemStatus Status { get; set; }

		public ReminderItemCreateModel()
		{

		}

		public ReminderItemCreateModel(ReminderItemRestricted reminderItem)
		{
			Date = reminderItem.Date;
			ContactId = reminderItem.ContactId;
			Message = reminderItem.Message;
			Status = reminderItem.Status;
		}

		public ReminderItemRestricted ToReminderItem()
		{
			return new ReminderItemRestricted
			{

				Date = Date,
				ContactId = ContactId,
				Message = Message,
				Status = Status
			};
		}
	}
}
