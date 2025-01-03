using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using YgomGame.Dialog.CommonDialog;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Menu
{
	public class LoginBonusMapWidet : ElementWidgetBase
	{
		private const string TWLABEL_STARTDIR = "StartDirection";

		private const string k_ELabelSlotGroup = "SlotGroup";

		private const string k_ELabelSlotTemplate = "SlotTemplate";

		private const string k_ELabelSlotCocatorFormat = "SlotLocator{0:D2}";

		private const string k_ELabelSpriteDayFormat = "day{0}";

		private const string k_ELabelHoldingDate = "TextDate";

		private readonly LoginBonusSlotWidget[] m_SlotWidgets;

		public int progress
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int addProgress
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isSentPresentBox
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool startDirEnd
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public LoginBonusSlotWidget[] slotWidgets => null;

		public LoginBonusMapWidet(ElementObjectManager eom)
			: base(null)
		{
		}

		public void Ready()
		{
		}

		public void SetData(Dictionary<string, object> source, bool obtaining)
		{
		}

		public void ShowObtainedItemAndGoToNext(EntryItemListData itemList, bool isPresentSent, Action callback)
		{
		}

		public void SelectSlot()
		{
		}
	}
}
