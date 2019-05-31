using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.JsonPatch;

namespace Reminder.Storage.WebApi.Core
{
	class ReminderItemsUpdateModel
	{
		public class ReminderItemsUpdateModel
		{
			[Required]
			public List<Guid> IDs { get; set; }
			[Required]
			public JsonPatchDocument<ReminderItemUpdateModel> PatchDocument { get; set; }


		}
	}
}
