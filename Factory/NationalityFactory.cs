using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
	abstract class NationalityFactory
	{
		public abstract Man CreateMan();
		public abstract Woman CreateWoman();
	}
}
