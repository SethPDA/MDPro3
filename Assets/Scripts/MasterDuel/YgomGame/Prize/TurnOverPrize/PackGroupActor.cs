using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Prize.TurnOverPrize
{
	public class PackGroupActor : ElementWidgetBase
	{
		private const string k_ELabelPackFormat = "Pack{0:D2}";

		private PackActor[] m_Packs;

		public PackActor[] packs => null;

		public PackGroupActor(ElementObjectManager eom)
			: base(null)
		{
		}

		public void SetButtonsEnabled(bool enabled)
		{
		}

		public void SetArrowsVisible(bool enabled)
		{
		}
	}
}
