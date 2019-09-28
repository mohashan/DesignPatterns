using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
	abstract class Woman : IHuman
	{
		public abstract void Greeting(IHuman human);

		public void SaySomething(string something)
		{
			Console.WriteLine($"{this.GetType().Name} : " + something);
		}
	}
}
