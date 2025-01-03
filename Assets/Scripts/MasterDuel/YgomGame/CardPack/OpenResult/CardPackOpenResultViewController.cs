using System;
using System.Collections;
using System.Collections.Generic;
using YgomGame.Dialog.CommonDialog;
using YgomGame.Menu;
using YgomGame.Shop;
using YgomSystem.UI;

namespace YgomGame.CardPack.OpenResult
{
	public class CardPackOpenResultViewController : BaseMenuViewController
	{
		private readonly string k_ELabelAnalogDirectionItem;

		private readonly string k_ELabelObtainedCardsRoot;

		private readonly string k_ELabelFoundedSecretPacksRoot;

		private readonly string k_ELabelShowOwnedNumToggle;

		private readonly string k_ELabelFootBar;

		private readonly string k_ELabelOKButton;

		private Dictionary<string, object> m_GachaResultWork;

		private Selector m_FootBarSelector;

		private ObtainedCardsWidget m_ObtainedCardsWidget;

		private FoundedSecretPacksWidget m_FoundedSecretPacksWidget;

		private bool m_OpenFoundedSecretTrigger;

		private bool m_OpenNextFinalizedURTrigger;

		private (EntryItemListData, bool, bool) m_PlayObtainItems;

		protected override Type[] textIds => null;

		protected override int selectorPriorityAddRange => 0;

		protected override bool setSurfaceActiveOnInitialize => false;

		public static void SwapOpen(ViewController fromVc)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private IEnumerator Start()
		{
			return null;
		}

		private void CheckOpenNotices()
		{
		}

		private void OnInputAnalogDirection(SelectorManager.AnalogType analogType, PadInputDirection dir)
		{
		}

		private void OnClickPack(ProductContext packProductContext)
		{
		}

		private void OnDecidedOpenSecretPacks(int shopId)
		{
		}

		private bool ReplaceOpenSecretPacks(int shopId)
		{
			return false;
		}

		public override void NotificationStackRemove()
		{
		}
	}
}
