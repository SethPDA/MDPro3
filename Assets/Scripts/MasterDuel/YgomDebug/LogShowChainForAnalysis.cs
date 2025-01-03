using System.Collections.Generic;
using YgomSystem.ElementSystem;

namespace YgomDebug
{
	public class LogShowChainForAnalysis : LogItemBaseForAnalysis
	{
		protected string LABEL_EO_CHAINNUM;

		protected string LABEL_EO_CHAINTEXT;

		protected string LABEL_EO_MINICARD;

		protected static Dictionary<ShowChainDataForAnalysis.ChainDataTypeForAnalysis, string> m_ChainLabelDict;

		private ElementObjectManager m_EOManager_Origin;

		protected ElementObjectManager m_EOManager => null;

		public void SetData(ShowChainDataForAnalysis data)
		{
		}

		public static void ResetWordTable()
		{
		}
	}
}
