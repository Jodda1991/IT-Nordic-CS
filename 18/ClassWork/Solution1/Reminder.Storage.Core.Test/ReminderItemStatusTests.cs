using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Reminder.Storage.Core.Test
{
	[TestClass]
	public class ReminderItemStatusTests
	{
		[TestMethod]
		public void Enum_First_Element_Testing()
		{
			ReminderItemStatus firstElement = 0;

			Assert.AreEqual(firstElement, ReminderItemStatus.Awaiting);

		}

		[TestMethod]
		public void Enum_Second_Element_Testing()
		{
			ReminderItemStatus secondElement = (ReminderItemStatus)1;

			Assert.AreEqual(secondElement, ReminderItemStatus.ReadyToSend);

		}

		[TestMethod]
		public void Enum_Third_Element_Testing()
		{
			ReminderItemStatus thirdElement = (ReminderItemStatus)2;

			Assert.AreEqual(thirdElement, ReminderItemStatus.SuccessfullySent);

		}

		[TestMethod]
		public void Enum_Fourth_Element_Testing()
		{
			ReminderItemStatus fourthElement = (ReminderItemStatus)3;

			Assert.AreEqual(fourthElement, ReminderItemStatus.Failed);

		}
	}
}
