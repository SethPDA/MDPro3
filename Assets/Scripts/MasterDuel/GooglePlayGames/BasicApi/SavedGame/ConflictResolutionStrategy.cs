namespace GooglePlayGames.BasicApi.SavedGame
{
	public enum ConflictResolutionStrategy
	{
		UseLongestPlaytime = 0,
		UseOriginal = 1,
		UseUnmerged = 2,
		UseManual = 3,
		UseLastKnownGood = 4,
		UseMostRecentlySaved = 5
	}
}
