namespace Factory
{
	public interface IHuman
	{
		void Greeting(IHuman human);
		void SaySomething(string something);
	}
}
