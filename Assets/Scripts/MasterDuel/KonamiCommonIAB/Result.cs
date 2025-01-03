namespace KonamiCommonIAB
{
	public abstract class Result
	{
		public const int IAP_SUCCESS = 0;

		public const int IAP_FAILED = -1;

		public const int IAP_CANCEL = -2;

		public const int IAP_DEFERRED = -3;

		public abstract int code { get; }

		public abstract int getResponse();

		public abstract string getMessage();

		public abstract bool isSuccess();

		public abstract bool isFailure();
	}
}
