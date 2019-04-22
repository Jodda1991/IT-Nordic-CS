using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	interface IReminderSender
	{
		ReminderItem[] GetReminderItemsToSend();
	}
}
