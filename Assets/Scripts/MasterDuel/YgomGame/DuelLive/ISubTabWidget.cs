namespace YgomGame.DuelLive
{
	public interface ISubTabWidget
	{
		SubTabGroupWidget parentGroup { get; }

		DuelLiveTabWidget tabWidget { get; }
	}
}
