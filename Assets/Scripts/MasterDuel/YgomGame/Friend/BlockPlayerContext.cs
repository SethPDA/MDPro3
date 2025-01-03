namespace YgomGame.Friend
{
	public class BlockPlayerContext : PlayerContextBase
	{
		private long m_BlockDateTs;

		public new void Import(object blockPlayerData)
		{
		}

		public override int CompareTo(IPlayerContext other)
		{
			return 0;
		}
	}
}
