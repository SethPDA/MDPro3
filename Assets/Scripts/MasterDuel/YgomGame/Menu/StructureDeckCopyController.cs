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
	public class StructureDeckCopyController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		private class DeckReference
		{
			public int id;

			public int structureId;

			public string name;

			public int caseID;

			public int protectorID;

			public int[] pickUpIDs;

			public int[] pickUpDecos;
		}

		private readonly string k_ELabelScrollView;

		private readonly string k_ELabelDeckTemplate;

		private readonly string k_ELabelTournamentDeckTemplate;

		private readonly string k_ELabelHederArea;

		private readonly string k_ELabelFooterArea;

		private readonly string k_ELabelDeckNum;

		private readonly string k_ELabelTournamentDeckNum;

		private readonly string k_ELabelStructureDeckView;

		private readonly string k_ELabelTextHeadline;

		private readonly string k_ELabelPickupCardButton;

		private Transform m_DeckNum;

		private Transform m_TournamentDeckNum;

		private Transform m_StructureDeckView;

		private ElementObjectManager m_StructureDeckViewEom;

		private SelectionButton m_StructureDeckViewButton;

		private Transform m_StructureDeckViewOn;

		private Transform m_StructureDeckViewOff;

		private TextMeshProUGUI m_TextHeadline;

		private SelectionButton m_PickupCardButton;

		private ElementObjectManager m_PickupCardButtonEom;

		private Transform m_PickupCardButtonOn;

		private Transform m_PickupCardButtonOff;

		[SerializeField]
		private ElementObjectManager m_PrefabUI;

		protected ElementObjectManager m_UI;

		private Transform m_HederArea;

		private Transform m_FooterArea;

		private ElementObjectManager m_DeckTemplate;

		private ElementObjectManager m_TournamentDeckTemplate;

		private InfinityScrollView m_ScrollView;

		private ElementObjectManager m_ScrollViewEom;

		private const string GROUP_LABEL = "StructureDeckCopy";

		private bool m_OnlyHaving;

		private bool dispPickCards;

		private List<int> m_NewIconList;

		private Dictionary<int, DeckBox> m_DeckUIs;

		private List<DeckReference> m_Decks;

		private List<DeckReference> m_hasDecks;

		private List<DeckReference> m_notHasDecks;

		protected override int selectorPriorityAddRange => 0;

		protected override Type[] textIds => null;

		public override void NotificationStackEntry()
		{
		}

		private void OnClickOnlyHaving()
		{
		}

		private void DispPickupCards()
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

		private void OnClickStuructureDeck(int structureId, ElementObjectManager body)
		{
		}

		private IEnumerator Initialize()
		{
			return null;
		}

		private void CheckFirstStructure()
		{
		}

		private void GetStructureDecks()
		{
		}

		private void UpdateStructureDecks()
		{
		}
	}
}
