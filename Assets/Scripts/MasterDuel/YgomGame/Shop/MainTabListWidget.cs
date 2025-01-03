using System.Collections.Generic;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Shop
{
	public class MainTabListWidget : ElementWidgetBase
	{
		private const string k_ELabelFormatTab = "Tab{0:D2}";

		public readonly Selector selector;

		private readonly ShopTabWidget[] m_SourceTabWidgets;

		private readonly List<ShopTabWidget> m_ActiveTabWidets;

		private IMainTabListWidgetHandler m_Handler;

		private IMainTabListWidgetListener m_Listener;

		public MainTabListWidget(ElementObjectManager eom)
			: base(null)
		{
		}

		public void Init(IMainTabListWidgetHandler handler, IMainTabListWidgetListener listener)
		{
		}

		public void UpdateDataCount()
		{
		}

		public void UpdateData()
		{
		}

		public bool SelectCurrentIdx(bool isInitializeSelect = false)
		{
			return false;
		}

		public bool CheckRecoverSelectItem()
		{
			return false;
		}
	}
}
