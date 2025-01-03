using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using YgomGame.Deck;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Menu
{
	public class PublicDeckSearchController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		protected class DeckReference
		{
			public int id;

			public int pickupId;

			public string cardgameId;

			public int deckNo;
		}

		protected readonly string k_ELabelScrollView;

		protected readonly string k_ELabelDeckTemplate;

		protected readonly string k_ELabelTournamentDeckTemplate;

		protected readonly string k_ELabelPublicDeckTemplate;

		protected readonly string k_ELabelHederArea;

		protected readonly string k_ELabelFooterArea;

		protected readonly string k_ELabelTextHeadline;

		protected readonly string k_ELabelEmptyMessage;

		protected readonly string k_ELabelEmptyMessageText;

		protected readonly string k_ELabelDeckNum;

		protected readonly string k_ELabelTournamentDeckNum;

		protected readonly string k_ELabelInputField;

		protected readonly string k_ELabelPlaceholder;

		protected readonly string k_ELabelButtonFilter;

		protected readonly string k_ELabelButtonTrash;

		protected readonly string k_ELabelButtonTrashSub;

		protected readonly string k_ELabelButtonPageUp;

		protected readonly string k_ELabelButtonPageDown;

		protected readonly string k_ELabelButtonCaution;

		protected Transform m_DeckNum;

		protected Transform m_TournamentDeckNum;

		protected ElementObjectManager m_InputFieldEom;

		protected Transform m_ButtonFilter;

		protected ElementObjectManager m_FilterEom;

		protected Transform m_FileterOn;

		protected Transform m_FileterOff;

		protected SelectionButton m_ButtonTrash;

		protected SelectionButton m_ButtonTrashSub;

		protected TextMeshProUGUI m_TextHeadline;

		private SelectionButton m_ButtonPageUp;

		private SelectionButton m_ButtonPageDown;

		protected SelectionButton m_ButtonCaution;

		protected const int numRequestPerPage = 100;

		protected int maxPageIdx;

		protected int nextPageIdx;

		protected int totalDecks;

		protected bool isUpdating;

		protected Transform m_HederArea;

		protected Transform m_FooterArea;

		private ElementObjectManager m_DeckTemplate;

		private ElementObjectManager m_TournamentDeckTemplate;

		private ElementObjectManager m_PublicDeckTemplate;

		protected InfinityScrollView m_ScrollView;

		protected ElementObjectManager m_ScrollViewEom;

		private string m_Keyword;

		private int[] m_CardArray;

		private List<CategoryReference> m_SelectedCategories;

		private List<CategoryReference> m_SelectedTags;

		private const string GROUP_LABEL = "PublicDeckSerach";

		protected const int MAX_MAIN = 60;

		protected const int MAX_EX = 15;

		private GameObject m_EmptyMessage;

		private TextMeshProUGUI m_EmptyMessageText;

		protected Dictionary<int, PublicDeckBox> m_PublicDeckUIs;

		protected bool updateFlag;

		protected Dictionary<string, object> deckDict;

		protected List<DeckReference> m_PublicDecks;

		protected override int selectorPriorityAddRange => 0;

		protected override Type[] textIds => null;

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		public void OnItemInitialize(GameObject gob)
		{
		}

		public void OnGsvStanby()
		{
		}

		public virtual void OnItemSetData(GameObject gob, int dataindex)
		{
		}

		public void OnItemExit(GameObject gob, int dataindex)
		{
		}

		public virtual IEnumerator DeckSearch_Search(int requestPageNo = 0)
		{
			return null;
		}

		protected virtual void DeckSearch_Detail(string targetId, int deckNo, int pickCardId)
		{
		}

		protected virtual void OnClickPublicDeck(string cardgameId, int deckNo, int pickCardId)
		{
		}

		public virtual void OpenDeckBrowser(string cardgameId, int deckNo, int pickCardId)
		{
		}

		protected virtual IEnumerator Initialize()
		{
			return null;
		}

		protected virtual IEnumerator AdditionalDeckDataLoad()
		{
			return null;
		}

		private void OpenFilterWindow()
		{
		}

		private void SetKeyWord(string keyword)
		{
		}

		private void ClearFilters()
		{
		}

		private bool IsActiveFilter()
		{
			return false;
		}

		private void OpenCautionMMA()
		{
		}

		protected virtual void UpdateDecks()
		{
		}

		public override bool OnResult(ViewController from, object value)
		{
			return false;
		}

		private void UpdateFilter()
		{
		}

		private IEnumerator DeckSearchRequest()
		{
			return null;
		}

		private void SortMRK(List<object> mrklist)
		{
		}

		public static int[] GetCardArrayByKeyword(string keyword)
		{
			return null;
		}

		private void JumpScrollIdx(PadInputDirection direction)
		{
		}

		protected virtual void OpenMaintenanceDialog()
		{
		}
	}
}
