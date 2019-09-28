using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
	class Tom : Man
	{

		public override void Greeting(IHuman human)
		{
			Console.WriteLine($"Hi, {human.GetType().Name}, I am {this.GetType().Name}.");
		}

	}
}
