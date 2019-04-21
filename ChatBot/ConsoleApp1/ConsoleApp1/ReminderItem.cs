using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	class ReminderItem: IReminderStorage,IReminderSender
	{
		public DateTimeOffset AlarmDate { get; set; }

		public string AlarmMessage { get; set; }

		public string ContactId { get; set; }

		Guid Id
		{
			get { return Guid.NewGuid(); }
		}

		public TimeSpan TimeToAlarm
		{
			get { return AlarmDate.Subtract(DateTimeOffset.UtcNow); }
		}

		public bool IsOutdated
		{
			get
			{
				return TimeToAlarm >= TimeSpan.Zero
				   ? true
				   : false;
			}
		}

		public ReminderItem(DateTimeOffset alarmDate, string alarmMessage, string contactId)
		{
			AlarmDate = alarmDate;
			AlarmMessage = alarmMessage;
			ContactId = contactId;	
		}

		public void Add()
		{
			
		}

		public void Update()
		{
			throw new NotImplementedException();
		}

		public void Get()
		{
			throw new NotImplementedException();
		}

		public ReminderItem[] GetReminderItemsToSend()
		{
			throw new NotImplementedException();
		}
	}
}
