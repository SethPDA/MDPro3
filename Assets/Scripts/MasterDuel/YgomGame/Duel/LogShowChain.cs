using System.Collections.Generic;
using YgomSystem.ElementSystem;

namespace YgomGame.Duel
{
	public class LogShowChain : LogItemBase
	{
		protected string LABEL_EO_CHAINNUM;

		protected string LABEL_EO_CHAINTEXT;

		protected string LABEL_EO_MINICARD;

		protected static Dictionary<ShowChainData.ChainDataType, string> m_ChainLabelDict;

		private ElementObjectManager m_EOManager_Origin;

		protected ElementObjectManager m_EOManager => null;

		public void SetData(ShowChainData data)
		{
		}

		public static void ResetWordTable()
		{
		}
	}
}
