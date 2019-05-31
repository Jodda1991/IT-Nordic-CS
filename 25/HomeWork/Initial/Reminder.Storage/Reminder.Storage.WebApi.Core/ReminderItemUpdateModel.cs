using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.JsonPatch;

namespace Reminder.Storage.WebApi.Core
{
	class ReminderItemUpdateModel
	{
		public class ReminderItemsUpdateModel
		{
			[Required]
			[Range(0, 3)]
			public ReminderItemStatus Status { get; set; }

		}
	}
}
