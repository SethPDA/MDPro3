using YgomSystem.ElementSystem;

namespace YgomGame.Duel
{
	public class LogShowPhase : LogItemBase
	{
		protected string LABEL_EO_PHASETEXT;

		protected string LABEL_EO_CARDNAME;

		private ElementObjectManager m_EOManager_Origin;

		protected ElementObjectManager m_EOManager => null;

		public void SetData(ShowPhaseData data)
		{
		}
	}
}
