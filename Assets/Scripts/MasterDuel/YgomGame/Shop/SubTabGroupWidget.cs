using System.Collections.Generic;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Shop
{
	public class SubTabGroupWidget : ElementWidgetBase, ISubTabWidget
	{
		private const string k_ELabelHandleToggle = "HandleToggle";

		private const string k_TLabelToOpen = "ToOpen";

		private const string k_TLabelToClose = "ToClose";

		private readonly ShopTabWidget m_TabWidget;

		private readonly ElementEntityFactory m_EntityFactory;

		private List<Tween> m_ToOpenTweens;

		private List<Tween> m_ToCloseTweens;

		public ShopTabWidget tabWidget => null;

		public ElementEntityFactory entityFactory => null;

		public SubTabGroupWidget parentGroup => null;

		public int dataCount => 0;

		private List<Tween> GetTweenByLabel(string label)
		{
			return null;
		}

		public SubTabGroupWidget(ElementObjectManager eom)
			: base(null)
		{
		}

		public void CaptureTweenFrom()
		{
		}

		public void PlayTween(bool isOn, bool immediate = false)
		{
		}

		private void CheckCollectTween()
		{
		}

		private void StopAllTween()
		{
		}

		private void TargetGotoAndPlayLabel(string label, bool wakeup, bool immediate)
		{
		}
	}
}
