namespace GooglePlayGames.BasicApi
{
	public enum LoadFriendsStatus
	{
		Unknown = 0,
		Completed = 1,
		LoadMore = 2,
		ResolutionRequired = -3,
		InternalError = -4,
		NotAuthorized = -5,
		NetworkError = -6
	}
}
