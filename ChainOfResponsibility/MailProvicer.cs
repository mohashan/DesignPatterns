using System;

namespace ChainOfResponsibility
{
	public class MailProvicer : MessageProcessor
	{
		public MailProvicer(MessageProcessor Successor)
		{
			_successor = Successor;
		}
		public override void ProcessMessage(Message message)
		{
			if (message.Channel == "mail")
				Console.WriteLine("Message Sent via email");
			else if (_successor != null)
			{
				_successor.ProcessMessage(message);
			}
			else
			{
				ProviderNotFound(message);
			}
		}
	}
}
