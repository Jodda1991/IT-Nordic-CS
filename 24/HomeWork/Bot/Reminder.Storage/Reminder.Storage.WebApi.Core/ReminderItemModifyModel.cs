using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Reminder.Storage.Core;

namespace Reminder.Storage.WebApi.Core
{
	public class ReminderItemModifyModel
	{
		[Required]
		[Range(0, 3)]
		public ReminderItemStatus Status { get; set; }

		public ReminderItemModifyModel(ReminderItemStatus status)
		{
			Status = status;
		}
	}
}
