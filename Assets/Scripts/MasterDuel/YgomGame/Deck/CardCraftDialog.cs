using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine.UI;
using YgomGame.Card;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Deck
{
	public class CardCraftDialog : SelectDialogViewControllerBase<CardCraftDialog.CraftMode, int, CardCollectionInfo.Premium, int>, IBokeSupported
	{
		public enum CraftMode
		{
			Create = 0,
			Dismantle = 1
		}

		private class CraftGroup : ElementWidget
		{
			private ElementObjectManager m_OperationEom;

			private ElementObjectManager m_ResultEom;

			//public RawImage m_CardImage
			//{
			//	[CompilerGenerated]
			//	get
			//	{
			//		return null;
			//	}
			//	[CompilerGenerated]
			//	private set
			//	{
			//	}
			//}

			//public Image m_Rarity
			//{
			//	[CompilerGenerated]
			//	get
			//	{
			//		return null;
			//	}
			//	[CompilerGenerated]
			//	private set
			//	{
			//	}
			//}

			public SelectionButton m_IncrementButton
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public SelectionButton m_DecrementButton
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public TMP_Text m_TextNum
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public TMP_Text m_TextBeforeNum
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public TMP_Text m_TextAfterNum
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public TMP_Text m_TextPremiumNum
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			//public Image m_CPIcon
			//{
			//	[CompilerGenerated]
			//	get
			//	{
			//		return null;
			//	}
			//	[CompilerGenerated]
			//	private set
			//	{
			//	}
			//}

			public TMP_Text m_TextBeforeCP
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public TMP_Text m_TextAfterCP
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public TMP_Text m_TextCompensation
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			private void InitializeOperationUI()
			{
			}

			private void InitializeResultUI()
			{
			}

			protected override void InitializeElements()
			{
			}
		}

		private const string PREFAB_PATH_CARDCRAFTDIALOG = "DeckEdit/CraftDialog";

		private CraftMode mode;

		private int currentCardNum;

		private int currentCraftPoint;

		private int createPoint;

		private int dismantlePoint;

		private int craftNum;

		private bool isCompensation;

		private int compensationId;

		private int compensationPoint;

		private int compensationNumMax;

		private string strEndTime;

		private Dictionary<int, CraftCompensation> m_CraftCompensations;

		private Dictionary<string, object> m_Compensations;

		private const string LABEL_SBN_CANCELBUTTON = "ButtonFooter0";

		private const string LABEL_SBN_CRAFTBUTTON = "ButtonFooter1";

		private const string LABEL_TXT_CRAFTBUTTONLABEL = "TextButtonFooter1";

		private const string LABEL_TXT_CANCELBUTTONLABEL = "TextButtonFooter0";

		private const string LABEL_TXT_CONFIRMATIONPROMPT = "TextDescription";

		private const string LABEL_TXT_CONFIRMATIONMESSAGE1 = "TextMessage1";

		private const string LABEL_TXT_CONFIRMATIONMESSAGE2 = "TextMessage2";

		private const string LABEL_TXT_DIALOGTITLE = "TextTitle";

		private TMP_Text m_Title;

		private TMP_Text m_CraftPrompt;

		private TMP_Text m_CraftMessage1;

		private TMP_Text m_CraftMessage2;

		private TMP_Text m_CraftButtonLabel;

		private TMP_Text m_CancelButtonLabel;

		private SelectionButton m_CraftButton;

		private SelectionButton m_CancelButton;

		private const int CREATE_NUM_MIN = 1;

		private const int CREATE_NUM_MAX = 3;

		private const int DISMANTLE_NUM_MIN = 1;

		private const int DISMANTLE_NUM_MAX = 99;

		private Action<int, int> OnDicidedCallback;

		private CraftGroup m_CraftGroup;

		private int m_CurrentCardID
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private CardCollectionInfo.Premium m_CurrentPremium
		{
			[CompilerGenerated]
			get
			{
				return default(CardCollectionInfo.Premium);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private void InitializeElements()
		{
		}

		public static void Open(CraftMode mode, int cardID, CardCollectionInfo.Premium prem, Action<int, int> callback = null)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void SetCraftNum(int craftNum)
		{
		}

		private void SetNumPremiums()
		{
		}

		private void CompensationCheck()
		{
		}

		public CardCraftDialog()
		{
			//((SelectDialogViewControllerBase<, , , >)(object)this)._002Ector();
		}
	}
}
