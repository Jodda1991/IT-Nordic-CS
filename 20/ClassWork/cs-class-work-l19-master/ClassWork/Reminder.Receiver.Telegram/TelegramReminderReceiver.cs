using System;
using System.Net;
using Reminder.Receiver.Core;
using Telegram.Bot;

namespace Reminder.Receiver.Telegram
{
	public class TelegramReminderReceiver : IReminderReceiver
	{
		private TelegramBotClient botClient;

		public event EventHandler<MessageReceivedEventArgs> MessageReceived;

		public TelegramReminderReceiver(string token)
		{
			//WebProxy wp = new WebProxy("92.168.1.100", true);
			//wp.Credentials = new NetworkCredential("user1", "user1Password");
			//botClient = new TelegramBotClient(token, wp);

			botClient = new TelegramBotClient(token);
		}

		public string GetHelloFromBot()
		{
			global::Telegram.Bot.Types.User user =
				botClient.GetMeAsync().Result;

			return $"Hello from user {user.Id}." +
				$"My name is {user.FirstName} {user.LastName}";
		}

		public void Run()
		{
			botClient.OnMessage += BotClient_OnMessage;
			botClient.StartReceiving();
		}

		private void BotClient_OnMessage(
			object sender,
			global::Telegram.Bot.Args.MessageEventArgs e)
		{
			if(e.Message.Type == global::Telegram.Bot.Types.Enums.MessageType.Text)
			{
				OnMessageReceived(
					this,
					new MessageReceivedEventArgs(
						e.Message.Chat.Id.ToString(),
						e.Message.Text));
			}
		}

		protected virtual void OnMessageReceived(object sender, MessageReceivedEventArgs e)
		{
			MessageReceived?.Invoke(sender, e);
		}
	}
}
