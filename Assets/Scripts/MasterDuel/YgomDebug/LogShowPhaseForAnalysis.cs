using YgomSystem.ElementSystem;

namespace YgomDebug
{
	public class LogShowPhaseForAnalysis : LogItemBaseForAnalysis
	{
		protected string LABEL_EO_PHASETEXT;

		protected string LABEL_EO_CARDNAME;

		private ElementObjectManager m_EOManager_Origin;

		protected ElementObjectManager m_EOManager => null;

		public void SetData(ShowPhaseDataForAnalysis data)
		{
		}
	}
}
