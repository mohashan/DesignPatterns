using System;

namespace ChainOfResponsibility
{
	public abstract class MessageProcessor
	{
		protected MessageProcessor _successor;

		public void ProviderNotFound(Message message)
		{
			Console.WriteLine($"Provider Not Found >> {message.Channel}");
		}
		public abstract void ProcessMessage(Message message);
	}
}
