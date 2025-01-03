using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using YgomGame.Deck;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.DeckBrowser
{
	public class TrialDrawWidget : DeckBrowserOptionWidget
	{
		private const string k_PrefPath = "Prefabs/UI/DeckBrowser/Optionals/DeckBrowserOptionForTrialDraw";

		private ShortcutKeySetter m_ShortcutSettings;

		private InfinityScrollView m_ScrollView;

		private SelectionButton m_PlusOneDrawButton;

		private List<object> m_DeckCardMrks;

		private List<object> m_DeckCardPremiums;

		private List<CardBaseData> m_DeckList;

		private TextMeshProUGUI m_TextDeckNum;

		private int m_Regulation;

		private List<CardBaseData> m_DeckListForTrialDraw;

		private List<CardBaseData> m_HandListForTrialDraw;

		private List<object> m_HandMrks;

		private List<object> m_HandPremiums;

		private CardDetailWidget m_DetailWidget;

		private bool isGamePad => false;

		private bool isMobile => false;

		public TrialDrawWidget(ElementObjectManager eom)
			: base(null)
		{
		}

		public static void Create(Transform parent, Action<TrialDrawWidget> onCreated)
		{
		}

		public void Init(List<object> mrks, List<object> prems, int regulation, CardDetailWidget detailView = null)
		{
		}

		private void FiveDraw()
		{
		}

		private void PlusOneDraw()
		{
		}

		private void DrawCard()
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

		public void SetDetailViewCard(int mrk, int premiumId)
		{
		}

		public void SetOnClickDetailViewCard(int idx)
		{
		}

		private void OnCreatedCardCallback(DeckCard deckCard, int idx)
		{
		}
	}
}
