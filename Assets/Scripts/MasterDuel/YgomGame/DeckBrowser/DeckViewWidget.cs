using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Deck;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.DeckBrowser
{
	public class DeckViewWidget : ElementWidgetBehaviourBase<DeckViewWidget>
	{
		private const string k_ELabelDeckNameText = "HeaderArea/TextDeckNameTMP";

		private const string k_ELabelTemplate = "MainDeckView/template";

		private const string k_ELabelMainDeckContent = "MainDeckView/MainDeckContent";

		private const string k_ELabelMainDeckNumText = "MainDeckView/TextMainDeckCardNum";

		private const string k_ELabelExtraDeckContent = "ExDeckView/ExDeckContent";

		private const string k_ELabelExtraDeckNumText = "ExDeckView/TextExDeckCardNum";

		private const string k_ELabelTemplateParent = "MainDeckView/TemplateParent";

		private const string k_ELabelLoadingIcon = "Loading";

		private TMP_Text m_DeckNameText;

		private DeckCardWidget m_Template;

		private RectTransform m_MainDeckContent;

		private TextMeshProUGUI m_MainDeckNumText;

		private RectTransform m_ExtraDeckContent;

		private TextMeshProUGUI m_ExtraDeckNumText;

		private List<DeckCardWidget> m_MainDeckWidgets;

		private List<DeckCardWidget> m_ExtraDeckWidgets;

		private Transform m_TemplateParent;

		private GameObject m_LoadingIcon;

		private GridLayoutGroup m_MainGridLayoutGroup;

		private const int CARDGROUP_ROW_MAX = 7;

		private InfinityScrollView m_InfinityScroll;

		private List<int> templateList;

		private bool m_IsMobile;

		public TMP_Text deckNameText => null;

		public TextMeshProUGUI mainDeckNumText => null;

		public TextMeshProUGUI extraDeckNumText => null;

		public IReadOnlyList<DeckCardWidget> mainDeckWidgets => null;

		public IReadOnlyList<DeckCardWidget> extraDeckWidgets => null;

		public static DeckViewWidget Create(ElementObjectManager eom, bool isMobile, int numDecks = 40, int numExDecks = 15)
		{
			return null;
		}

		public DeckCardWidget AddToMainDeckByID(int id, int prem = 1, bool isRental = false)
		{
			return null;
		}

		public DeckCardWidget AddToExtraDeckByID(int id, int prem = 1, bool isRental = false)
		{
			return null;
		}

		public DeckCardWidget AddToMainDeckMobile(DeckCard deckCard)
		{
			return null;
		}

		public DeckCardWidget AddToExtraDeckMobile(DeckCard deckCard)
		{
			return null;
		}

		private DeckCardWidget AddCard(Transform parent, int id, int prem = 1, bool isRental = false)
		{
			return null;
		}

		public void DispLoadingIcon(bool isLoading)
		{
		}

		public void SortInDeckCard()
		{
		}

		private void InitializeInfinityScroll()
		{
		}

		public void OnItemInitialize(GameObject gob)
		{
		}

		public void OnGsvStanby()
		{
		}

		public void OnItemSetData(GameObject gob, int dataindex)
		{
		}

		public DeckViewWidget()
		{
			//((ElementWidgetBehaviourBase<>)(object)this)._002Ector();
		}
	}
}
