using YgomSystem.ElementSystem;

namespace YgomDebug
{
	public class LogShowCardNameForAnalysis : LogItemBaseForAnalysis
	{
		protected string LABEL_EO_CONTENT;

		protected string LABEL_EO_COLORBARTEAM0;

		protected string LABEL_EO_COLORBARTEAM1;

		protected string LABEL_EO_CARDNAME;

		private ElementObjectManager m_EOManager_Origin;

		protected ElementObjectManager m_EOManager => null;

		public void SetData(ShowCardNameDataForAnalysis data)
		{
		}
	}
}
