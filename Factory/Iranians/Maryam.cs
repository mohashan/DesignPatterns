using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
	class Maryam: Woman
	{
		public override void Greeting(IHuman human)
		{
			Console.WriteLine($"Salam {human.GetType().Name} azizam... man {this.GetType().Name} hastam.");
		}

	}
}
