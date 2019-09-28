namespace Factory
{
	class AmericansFactory : NationalityFactory
	{
		public override Man CreateMan()
		{
			return new Tom();
		}

		public override Woman CreateWoman()
		{
			return new Betti();
		}
	}
}
