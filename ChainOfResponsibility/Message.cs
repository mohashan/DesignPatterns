namespace ChainOfResponsibility
{
	public class Message
	{
		public string Channel { get; set; }
		public string Body { get; set; }
		public string Receiver { get; set; }
	}
}
