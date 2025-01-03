namespace YgomGame.Duel
{
	public struct ShowChainData
	{
		public enum ChainDataType
		{
			SET = 0,
			RUN = 1,
			STEP = 2,
			END = 3
		}

		public short cardid;

		public short chainnum;

		public bool team;

		public ChainDataType type;

		//public ShowChainData(bool team, int cardid, int chainnum, ChainDataType type)
		//{
		//}
	}
}
