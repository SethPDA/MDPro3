using System.Collections.Generic;
using YgomSystem.ElementSystem;

namespace YgomDebug
{
	public class LogShowTextForAnalysis : LogItemBaseForAnalysis
	{
		public static List<string> m_TextTable;

		protected string LABEL_EO_CONTENT;

		protected string LABEL_EO_COLORBARTEAM0;

		protected string LABEL_EO_COLORBARTEAM1;

		protected string LABEL_EO_TEXT;

		private ElementObjectManager m_EOManager_Origin;

		protected ElementObjectManager m_EOManager => null;

		public void SetData(ShowTextDataForAnalysis data)
		{
		}
	}
}
