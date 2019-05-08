using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reminder.Receiver.Core;

namespace Reminder.Reciver.Core.Tests
{
	[TestClass]
	public class ReminderReceiverTests
	{
		[TestMethod]
		public void Constructor_Test()
		{
			string s = "123D";
			string w = "Wake up !";
			var receiver = new MessageReceivedEventArgs(s,w);

			Assert.AreEqual(receiver.ContactId, s);
			Assert.AreEqual(receiver.Message, w);

		}
	}
}
