using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reminder.Sender.Telegram;
using Telegram.Bot;

namespace TelegramReminderSenderTests
{
	[TestClass]
	public class TelegramReminderSenderTests
	{
		[TestMethod]
		public void Sender_Constructor_Test()
		{
			string cn = "Alex";
			string mes = "Work Hard";
			var sender = new TelegramReminderSender("1234567:4TT8bAc8GHUspu3ERYn-KGcvsvGB9u_n4ddy");
			sender.Send("Alex", "Work Hard");

			var test = new TelegramReminderSender("1234567:4TT8bAc8GHUspu3ERYn-KGcvsvGB9u_n4ddy");
			test.Send("Alex", "Work Hard");
			Assert.AreEqual(sender, test);
		}
	}
}
