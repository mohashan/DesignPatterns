using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
	class Betti : Woman
	{
		public override void Greeting(IHuman human)
		{
			Console.WriteLine($"Hello, {human.GetType().Name}, my darling. I am {this.GetType().Name}.");
		}

	}
}
