﻿using System;
using System.Collections.Generic;

namespace Reminder.Storage.Core
{
	public interface IReminderStorage
	{
		/// <summary>
		/// Adds new reminder item to collection.
		/// </summary>
		void Add(ReminderItem reminderItem);
		/// <summary>
		/// Updates existing reminder item.
		/// </summary>
		void Update(ReminderItem reminderItem);

		ReminderItem Get(Guid id);

		List<ReminderItem> GetList(IEnumerable<ReminderItemStatus> status ,int count, int startPosition);

	}
}
