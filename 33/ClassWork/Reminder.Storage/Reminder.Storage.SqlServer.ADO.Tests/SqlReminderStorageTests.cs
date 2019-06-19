using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reminder.Storage.Core;

namespace Reminder.Storage.SqlServer.ADO.Tests
{
	[TestClass]
	public class SqlReminderStorageTests
	{
		private const string _connectionString =
			@"Data Source=localhost\SQLEXPRESS;Initial Catalog=ReminderTests;Integrated Security=true;";

		[TestInitialize]
		public void TestInitialize()
		{
			var dbInit = new SqlReminderStorageInit(_connectionString);
			dbInit.InitializeDatabase();
		}

        [TestMethod]
        public void Property_Count_Returns_8_For_Initial_Data_Set()
        {
            var storage = new SqlReminderStorage(_connectionString);

            int actual = storage.Count;
            Assert.AreEqual(8, actual);
        }

        [TestMethod]
        public void Property_Remove_Method()
        {
            var storage = new SqlReminderStorage(_connectionString);

            Guid id = new Guid("00000000-0000-0000-0000-111111111111");

            bool result = storage.Remove(id);

            Assert.AreEqual(true, result);
        }

        [TestMethod]
		public void Method_Add_Returns_Not_Empty_Guid()
		{
			var storage = new SqlReminderStorage(_connectionString);

			Guid actual = storage.Add(new Core.ReminderItemRestricted
			{
				ContactId = "TestContactId",
				Date = DateTimeOffset.Now.AddHours(1),
				Message = "Test Message",
				Status = Core.ReminderItemStatus.Awaiting
			});

			Assert.AreNotEqual(Guid.Empty, actual);
		}

		[TestMethod]
		public void Get_By_Id_Method_Returns_Just_Added_Item()
		{
			var storage = new SqlReminderStorage(_connectionString);

			DateTimeOffset expectedDate = DateTimeOffset.Now;
			string expectedContactId = "TEST_CONTACT_ID";
			string expectedMessage = "TEST_MESSAGE_TEXT";
			ReminderItemStatus expectedStatus = ReminderItemStatus.Awaiting;

			Guid id = storage.Add(new ReminderItemRestricted
			{
				ContactId = expectedContactId,
				Date = expectedDate,
				Message = expectedMessage,
				Status = expectedStatus
			});

			Assert.AreNotEqual(Guid.Empty, id);

			var actualItem = storage.Get(id);

			Assert.IsNotNull(actualItem);
			Assert.AreEqual(id, actualItem.Id);
			Assert.AreEqual(expectedDate, actualItem.Date);
			Assert.AreEqual(expectedContactId, actualItem.ContactId);
			Assert.AreEqual(expectedMessage, actualItem.Message);
			Assert.AreEqual(expectedStatus, actualItem.Status);
		}

		[TestMethod]
		public void Get_By_Id_Method_Returns_Not_Null_Item_With_Proper_Fields()
		{
			Guid expectedGuid = Guid.Parse("00000000-0000-0000-0000-111111111111");
			DateTimeOffset expectedDate = DateTimeOffset.Parse("2020-01-01 00:00:00 +00:00");
			string expectedContactId = "ContactId_1";
			string expectedMessage = "Message_1";
			ReminderItemStatus expectedStatus = ReminderItemStatus.Awaiting;

			var storage = new SqlReminderStorage(_connectionString);
			var actualItem = storage.Get(expectedGuid);

			Assert.IsNotNull(actualItem);
			Assert.AreEqual(expectedGuid, actualItem.Id);
			Assert.AreEqual(expectedContactId, actualItem.ContactId);
			Assert.AreEqual(expectedDate, actualItem.Date);
			Assert.AreEqual(expectedMessage, actualItem.Message);
			Assert.AreEqual(expectedStatus, actualItem.Status);
		}

		[TestMethod]
		public void Get_By_Id_Method_Returns_Null_If_Not_Found()
		{
			var storage = new SqlReminderStorage(_connectionString);

			var actual = storage.Get(Guid.Empty);

			Assert.IsNull(actual);
		}

		[TestMethod]
		public void Get_By_Id_Method_Returns_Russian_Message_After_Adding()
		{
			DateTimeOffset expectedDate = DateTimeOffset.Parse("2020-01-01 00:00:00 +00:00");
			string expectedContactId = "ContactId_1";
			string expectedMessage = "Сообщение на русском языке :)";
			ReminderItemStatus expectedStatus = ReminderItemStatus.Awaiting;

			var storage = new SqlReminderStorage(_connectionString);
			Guid justAddedReminderId = storage.Add(new ReminderItemRestricted
			{
				ContactId = expectedContactId,
				Date = expectedDate,
				Message = expectedMessage,
				Status = expectedStatus
			});
			var actualItem = storage.Get(justAddedReminderId);

			Assert.IsNotNull(actualItem);
			Assert.AreEqual(justAddedReminderId, actualItem.Id);
			Assert.AreEqual(expectedContactId, actualItem.ContactId);
			Assert.AreEqual(expectedDate, actualItem.Date);
			Assert.AreEqual(expectedMessage, actualItem.Message);
			Assert.AreEqual(expectedStatus, actualItem.Status);
		}

		[TestMethod]
		public void Get_Method_With_Status_Only_Returns_All_Reminders_With_Requested_Status()
		{
			var storage = new SqlReminderStorage(_connectionString);

			List<ReminderItem> actual;

			actual = storage.Get(ReminderItemStatus.Awaiting);
			Assert.IsNotNull(actual);
			Assert.AreEqual(2, actual.Count);

			actual = storage.Get(ReminderItemStatus.Ready);
			Assert.IsNotNull(actual);
			Assert.AreEqual(1, actual.Count);

			actual = storage.Get(ReminderItemStatus.Sent);
			Assert.IsNotNull(actual);
			Assert.AreEqual(2, actual.Count);

			actual = storage.Get(ReminderItemStatus.Failed);
			Assert.IsNotNull(actual);
			Assert.AreEqual(3, actual.Count);
		}

		[TestMethod]
		public void UpdateStatus_Method_With_Status_Only_Returns_All_Reminders_With_Requested_Status()
		{
			var storage = new SqlReminderStorage(_connectionString);

			IEnumerable<Guid> selectedReminderIds = storage
				.Get(ReminderItemStatus.Awaiting)
				.Select(x => x.Id);

			storage.UpdateStatus(selectedReminderIds, ReminderItemStatus.Failed);

			var actual = storage.Get(ReminderItemStatus.Failed);
			Assert.IsNotNull(actual);
			Assert.AreEqual(5, actual.Count);
		}
	}
}
