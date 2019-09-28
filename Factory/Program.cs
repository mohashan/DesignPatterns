using System;

namespace Factory
{
	class Program
	{
		static void Main(string[] args)
		{
			IranianFactory iranian = new IranianFactory();
			AmericansFactory americans = new AmericansFactory();
			var IranianMan = iranian.CreateMan();
			var IranianWoman = iranian.CreateWoman();
			var AmericanMan = americans.CreateMan();
			var AmericanWoman = americans.CreateWoman();
			IranianMan.Greeting(AmericanWoman);
			AmericanWoman.Greeting(IranianMan);

			IranianWoman.Greeting(AmericanMan);
			AmericanMan.Greeting(IranianWoman);

			Console.ReadKey();
		}
	}
}
