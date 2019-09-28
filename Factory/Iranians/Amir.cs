using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
	class Amir : Man
	{

		public override void Greeting(IHuman human)
		{
			Console.WriteLine($"Salam {human.GetType().Name}... man {this.GetType().Name} hastam.");
		}

	}
}
