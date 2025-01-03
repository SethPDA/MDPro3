using System;
using YgomGame.Duel;

namespace YgomDebug
{
	[Serializable]
	public struct ShowChainDataForAnalysis
	{
		public enum ChainDataTypeForAnalysis
		{
			SET = 0,
			RUN = 1,
			STEP = 2,
			END = 3
		}

		public short cardid;

		public short chainnum;

		public bool team;

		public ChainDataTypeForAnalysis type;

		//public ShowChainDataForAnalysis(ShowChainData showChainData)
		//{
		//}
	}
}
