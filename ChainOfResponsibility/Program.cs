using System;

namespace ChainOfResponsibility
{
	class Program
	{
		static void Main(string[] args)
		{
			var smsMessage = new Message { Channel = "sms" };
			var mailMessage = new Message { Channel = "mail" };
			var firebaseMessage = new Message { Channel = "firebase" };
			var telegramMessage = new Message { Channel = "telegram" };

			var chainProviders = new SMSProvicer(new MailProvicer(new FirebaseProvicer(null)));

			chainProviders.ProcessMessage(smsMessage);
			chainProviders.ProcessMessage(mailMessage);
			chainProviders.ProcessMessage(firebaseMessage);
			chainProviders.ProcessMessage(telegramMessage);

			Console.ReadLine();
		}
	}
}
