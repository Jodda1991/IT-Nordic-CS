using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using Reminder.Storage.Core;

namespace Reminder.Storage.WebApi.Core
{
	public class ReminderItemModifyListModel
	{
		public List<Guid> IDs { get; set; }

		public ReminderItemModifyListModel()
		{

		}

		public ReminderItemModifyListModel(IEnumerable<Guid> ids , ReminderItemStatus status)
		{
			IDs = ids.ToList();
			Status = status;
		}

		/// <summary>
		/// Gets or sets the identifier of the recipient.
		[Required]
		[Range(0, 3)]
		public ReminderItemStatus Status { get; set; }

		
	}
}
