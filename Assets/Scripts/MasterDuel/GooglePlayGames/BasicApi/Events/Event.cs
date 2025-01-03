namespace GooglePlayGames.BasicApi.Events
{
	internal class Event : IEvent
	{
		private string mId;

		private string mName;

		private string mDescription;

		private string mImageUrl;

		private ulong mCurrentCount;

		private EventVisibility mVisibility;

		public string Id => null;

		public string Name => null;

		public string Description => null;

		public string ImageUrl => null;

		public ulong CurrentCount => 0uL;

		public EventVisibility Visibility => default(EventVisibility);

		internal Event(string id, string name, string description, string imageUrl, ulong currentCount, EventVisibility visibility)
		{
		}
	}
}
