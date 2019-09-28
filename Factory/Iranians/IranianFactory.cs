namespace Factory
{
	class IranianFactory : NationalityFactory
	{
		public override Man CreateMan()
		{
			return new Amir();
		}

		public override Woman CreateWoman()
		{
			return new Maryam();
		}
	}
}
