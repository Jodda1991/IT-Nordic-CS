using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reminder.Storage.Core;
using System;
using System.Collections.Generic;

namespace Reminder.Storage.InMemory.Test
{
	[TestClass]
	public class ReminderstorageTests
	{
		[TestMethod]
		public void Add_Method_Testing()
		{
			var storage = new ReminderStorage();
			Guid id = new Guid();
			var expected = new ReminderItem(id, DateTimeOffset.Now, null, null);

			storage.Add(expected);

			var actual = storage.Get(id);

			Assert.AreEqual(expected, actual);

		}

		[TestMethod]
		public void Get_Method_Testing()
		{
			var storage = new ReminderStorage();
			Guid id = new Guid();
			var item = new ReminderItem(id, DateTimeOffset.Now, null, null);

			storage.Add(item);

			var actual = storage.Get(id);

			Assert.AreEqual(item, actual);
		}

		[TestMethod]
		public void Update_Method_Testing()
		{
			var storage = new ReminderStorage();
			Guid id = new Guid();
			var item = new ReminderItem(id, DateTimeOffset.Now, null, null);

			storage.Add(item);

			item.ContactId = "Unknown tester #0001";

			Assert.AreEqual(item, storage.Get(id));
		}
	}
}
