using YgomSystem.ElementSystem;

namespace YgomGame.Duel
{
	public class LogShowCardName : LogItemBase
	{
		protected string LABEL_EO_CONTENT;

		protected string LABEL_EO_COLORBARTEAM0;

		protected string LABEL_EO_COLORBARTEAM1;

		protected string LABEL_EO_CARDNAME;

		private ElementObjectManager m_EOManager_Origin;

		protected ElementObjectManager m_EOManager => null;

		public void SetData(ShowCardNameData data)
		{
		}
	}
}
