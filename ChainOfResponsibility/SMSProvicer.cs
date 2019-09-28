using System;

namespace ChainOfResponsibility
{
	public class SMSProvicer : MessageProcessor
	{
		public SMSProvicer(MessageProcessor Successor)
		{
			_successor = Successor;
		}
		public override void ProcessMessage(Message message)
		{
			if (message.Channel == "sms")
				Console.WriteLine("Message Sent via sms");
			else if(_successor != null)
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
