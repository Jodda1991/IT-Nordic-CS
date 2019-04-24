using System;
using System.Collections.Generic;
using Reminder.Storage.Core;

namespace Reminder.Storage.InMemory
{
	public class ReminderStorage: IReminderStorage
	{
		private Dictionary<Guid, ReminderItem> _storage;

		public ReminderStorage()
		{
			_storage = new Dictionary<Guid, ReminderItem>();
		}
	

		public void Add(ReminderItem reminderItem)
		{
			if(_storage.ContainsKey(reminderItem.Id))
				throw new Exception ("Key is already exist!");
			else
			_storage.Add(reminderItem.Id, reminderItem);
		}

		public ReminderItem Get(Guid id)
		{
			return _storage.ContainsKey(id) 
				? _storage[id] 
				: null;
		}

		public List<ReminderItem> GetList(IEnumerable<ReminderItemStatus> status, int count, int startPosition)
		{
			var list = new List<ReminderItem>();

		}

		public void Update(ReminderItem reminderItem)
		{
			if (_storage.ContainsKey(reminderItem.Id) == false)
				throw new KeyNotFoundException("Key isn't found!");
			else
			_storage[reminderItem.Id] = reminderItem;
		}
	}
}
