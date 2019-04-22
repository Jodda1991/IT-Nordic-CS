using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Reminder.Storage.Core.Test
{
	[TestClass]
	public class ReminderItemTests
	{
		[TestMethod]
		public void Constructor_Validly_Fills_Id_Propetrty()
		{
			//Preparing 
			Guid expected = new Guid("D9B807AC-A4C2-4505-A947-2753B8E907C6");
			//Running
			var reminderItem = new ReminderItem(
				expected,
				DateTimeOffset.MinValue,
				null,
				null);
			//Checking
			Assert.AreEqual(expected, reminderItem.Id);
		}

		[TestMethod]
		public void Constructor_Validly_Fills_Date_Propetrty()
		{
			//Preparing 
			var expected = DateTimeOffset.Now;
			//Running
			var reminderItem = new ReminderItem(
				Guid.Empty,
				expected,
				null,
				null);
			//Checking
			Assert.AreEqual(expected, reminderItem.Date);
		}

		[TestMethod]
		public void TimeToSend_Is_In_500_ms_Range()
		{
			//Preparing 
			
			//Running
			var reminderItem = new ReminderItem(
				Guid.Empty,
				DateTimeOffset.UtcNow+TimeSpan.FromMilliseconds(500),
				null,
				null);

			var time500ms = TimeSpan.FromMilliseconds(500);

			var actual = reminderItem.TimeToSend;
			//Checking
			Assert.IsTrue(actual < time500ms);
			Assert.IsTrue(actual>TimeSpan.Zero);
		}

		[TestMethod]
		public void TimeToSend_Is_Less_Than_Zero_For_Past_Time()
		{
			//Preparing 

			//Running
			var reminderItem = new ReminderItem(
				Guid.Empty,
				DateTimeOffset.UtcNow -TimeSpan.FromDays(1),
				null,
				null);

			var actual = reminderItem.TimeToSend;
			//Checking
			Assert.IsTrue(actual < TimeSpan.Zero);
		}
	}
}
