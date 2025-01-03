namespace KonamiCommonIAB
{
	internal class iPhoneResult : Result
	{
		private int _code;

		public override int code => 0;

		public iPhoneResult(int r)
		{
		}

		public override bool isSuccess()
		{
			return false;
		}

		public override bool isFailure()
		{
			return false;
		}

		public override int getResponse()
		{
			return 0;
		}

		public override string getMessage()
		{
			return null;
		}
	}
}
