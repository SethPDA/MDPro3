using System;

namespace GooglePlayGames.BasicApi.SavedGame
{
	public struct SavedGameMetadataUpdate
	{
		public struct Builder
		{
			internal bool mDescriptionUpdated;

			internal string mNewDescription;

			internal bool mCoverImageUpdated;

			internal byte[] mNewPngCoverImage;

			internal TimeSpan? mNewPlayedTime;

			public Builder WithUpdatedDescription(string description)
			{
				return default(Builder);
			}

			public Builder WithUpdatedPngCoverImage(byte[] newPngCoverImage)
			{
				return default(Builder);
			}

			public Builder WithUpdatedPlayedTime(TimeSpan newPlayedTime)
			{
				return default(Builder);
			}

			public SavedGameMetadataUpdate Build()
			{
				return default(SavedGameMetadataUpdate);
			}
		}

		private readonly bool mDescriptionUpdated;

		private readonly string mNewDescription;

		private readonly bool mCoverImageUpdated;

		private readonly byte[] mNewPngCoverImage;

		private readonly TimeSpan? mNewPlayedTime;

		public bool IsDescriptionUpdated => false;

		public string UpdatedDescription => null;

		public bool IsCoverImageUpdated => false;

		public byte[] UpdatedPngCoverImage => null;

		public bool IsPlayedTimeUpdated => false;

		public TimeSpan? UpdatedPlayedTime => null;

		//private SavedGameMetadataUpdate(Builder builder)
		//{
		//}
	}
}
