namespace GooglePlayGames.BasicApi.Nearby
{
	public struct AdvertisingResult
	{
		private readonly ResponseStatus mStatus;

		private readonly string mLocalEndpointName;

		public bool Succeeded => false;

		public ResponseStatus Status => default(ResponseStatus);

		public string LocalEndpointName => null;

		//public AdvertisingResult(ResponseStatus status, string localEndpointName)
		//{
		//}
	}
}
