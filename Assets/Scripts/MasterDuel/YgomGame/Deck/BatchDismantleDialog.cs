using System;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.Card;
using YgomGame.Menu;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Deck
{
	public class BatchDismantleDialog : SelectDialogViewControllerBase<bool>, IBokeSupported
	{
		private const string PREFAB_PATH_BATCHDISMANTLEDIALOG = "DeckEdit/BatchDismantleDialog";

		private const string LABEL_SBN_CANCELBUTTON = "ButtonFooter0";

		private const string LABEL_SBN_DISMANTLEBUTTON = "ButtonFooter1";

		private const string LABEL_EOM_TEMPLATE = "Template";

		private const string LABEL_TXT_CANCELBUTTONLABEL = "TextButtonFooter0";

		private const string LABEL_TXT_DISMANTLEBUTTONLABEL = "TextButtonFooter1";

		private const string LABEL_TXT_POINTSGAINEDHEADER = "TextGetCP";

		private const string LABEL_TXT_NPOINTSGAINED = "TextGetCPNum0";

		private const string LABEL_TXT_RPOINTSGAINED = "TextGetCPNum1";

		private const string LABEL_TXT_SRPOINTSGAINED = "TextGetCPNum2";

		private const string LABEL_TXT_URPOINTSGAINED = "TextGetCPNum3";

		private const string LABEL_TXT_TOTALPOINTSHEADER = "TextCP";

		private const string LABEL_TXT_NTOTALPOINTS = "TextCPNum0";

		private const string LABEL_TXT_RTOTALPOINTS = "TextCPNum1";

		private const string LABEL_TXT_SRTOTALPOINTS = "TextCPNum2";

		private const string LABEL_TXT_URTOTALPOINTS = "TextCPNum3";

		private const string LABEL_TXT_DESC0 = "TextDescription0";

		private const string LABEL_TXT_DESC1 = "TextDescription1";

		private const string LABEL_TXT_DESC2 = "TextDescription2";

		private const string LABEL_TXT_DIALOGTITLE = "TextTitle";

		private const string LABEL_RT_LISTAREA = "ListArea";

		private const string LABEL_TXT_TEXTNUM = "TextCardNum";

		private const string LABEL_TXT_TEXTRARITY = "TextRarity";

		private ExtendedTextMeshProUGUI m_CancelButtonLabel;

		private ExtendedTextMeshProUGUI m_DismanlteButtonLabel;

		private ExtendedTextMeshProUGUI m_PointsGainedHeader;

		private ExtendedTextMeshProUGUI m_NPointsGained;

		private ExtendedTextMeshProUGUI m_RPointsGained;

		private ExtendedTextMeshProUGUI m_SRPointsGained;

		private ExtendedTextMeshProUGUI m_URPointsGained;

		private ExtendedTextMeshProUGUI m_TotalPointsHeader;

		private ExtendedTextMeshProUGUI m_NTotalPoints;

		private ExtendedTextMeshProUGUI m_RTotalPoints;

		private ExtendedTextMeshProUGUI m_SRTotalPoints;

		private ExtendedTextMeshProUGUI m_URTotalPoints;

		private ExtendedTextMeshProUGUI m_Desc0;

		private ExtendedTextMeshProUGUI m_Desc1;

		private ExtendedTextMeshProUGUI m_Desc2;

		private ExtendedTextMeshProUGUI m_DialogTitle;

		private SelectionButton m_DismantleButton;

		private SelectionButton m_CancelButton;

		private RectTransform m_ListArea;

		private Dictionary<int, CraftCompensation> m_CraftCompensations;

		private Dictionary<string, object> m_Compensations;

		private Dictionary<int, int> m_CompensationsRarities;

		private List<int> m_CompensationIds;

		public const string k_ArgKeyDialogTitle = "title";

		public const string k_ArgKeyDismantleCards = "dismantleCards";

		public const string k_ArgKeyOnCompleteCallback = "onCompleteCallback";

		public const string k_ArgKeyCreateCards = "createCards";

		public const string k_ArgKeyCreateCardsMessage = "createCardsMessage";

		private const string CP_TEXT_MAX = "99999+";

		private const string CP_TEXT_MIN = "0";

		private string m_Title;

		private List<CardBaseData> m_DismantleCards;

		private Action<bool> OnCompleteCallback;

		private Dictionary<int, int> m_CreateCards;

		private string m_CreatedCardsMessage;

		private Dictionary<string, object> formatedCards;

		private bool isSelectMode;

		private bool isCreateMode;

		private Dictionary<CardCollectionInfo.Rarity, bool> SufficientCheck;

		private void InitializeElements()
		{
		}

		public static void Open(Action<bool> callback = null)
		{
		}

		public static void Open(Dictionary<string, object> args = null)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		private void InitCompensation()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void InitilizeCreateMode()
		{
		}

		private void Dismauntle()
		{
		}

		private void Create()
		{
		}

		private List<CardBaseData> FormatCreateCards(Dictionary<int, int> lackCards)
		{
			return null;
		}

		private bool CompensationCheck(Dictionary<string, object> data)
		{
			return false;
		}

		public BatchDismantleDialog()
		{
			//((SelectDialogViewControllerBase<>)(object)this)._002Ector();
		}
	}
}
