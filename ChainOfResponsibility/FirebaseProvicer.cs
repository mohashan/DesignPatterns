using System;

namespace ChainOfResponsibility
{
	public class FirebaseProvicer : MessageProcessor
	{
		public FirebaseProvicer(MessageProcessor Successor)
		{
			_successor = Successor;
		}
		public override void ProcessMessage(Message message)
		{
			if (message.Channel == "firebase")
				Console.WriteLine("Message Sent via firebase");
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
