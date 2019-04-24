using Reminder.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reminder.Domain.EventArgs
{
	public class SendingSuccededEventArgs:System.EventArgs
	{
		public SendReminderModel Reminder { get; set; }

		public SendingSuccededEventArgs(SendReminderModel reminder)
		{
			Reminder = reminder;
		}
	}
}
