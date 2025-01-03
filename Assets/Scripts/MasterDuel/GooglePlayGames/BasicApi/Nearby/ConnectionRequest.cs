namespace GooglePlayGames.BasicApi.Nearby
{
	public struct ConnectionRequest
	{
		private readonly EndpointDetails mRemoteEndpoint;

		private readonly byte[] mPayload;

		public EndpointDetails RemoteEndpoint => default(EndpointDetails);

		public byte[] Payload => null;

		//public ConnectionRequest(string remoteEndpointId, string remoteEndpointName, string serviceId, byte[] payload)
		//{
		//}
	}
}
