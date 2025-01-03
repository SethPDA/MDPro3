using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Deck;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.DeckBrowser
{
	public class TrialDrawViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
	{
		private readonly string k_ELabelDetailView;

		private readonly string k_ELabelDetailViewMenuRoot;

		[SerializeField]
		private ElementObjectManager m_UIPrefab;

		[SerializeField]
		private ElementObjectManager m_UIPrefabMobile;

		private ElementObjectManager m_UI;

		private CardDetailWidget m_DetailWidget;

		private int m_Regulation;

		private const int thresClose = 5;

		private float holdTime;

		private readonly string k_ELabelTrialDraw;

		private readonly string k_ELabelTrialDrawInfinityView;

		private readonly string k_ELabelTextDeckNum;

		private readonly string k_ELabelFiveDrawButton;

		private readonly string k_ELabelPlusOneDrawButton;

		private readonly string k_ELabelRegulationIcon;

		private InfinityScrollView m_TrialDrawInfinityView;

		private SelectionButton m_FiveDrawButton;

		private SelectionButton m_PlusOneDrawButton;

		private Image m_RegulationIcon;

		private List<object> m_DeckCardMrks;

		private List<object> m_DeckCardPremiums;

		private List<CardBaseData> m_DeckList;

		private TextMeshProUGUI m_TextDeckNum;

		private List<CardBaseData> m_DeckListForTrialDraw;

		private List<CardBaseData> m_HandListForTrialDraw;

		private List<object> m_HandMrks;

		private List<object> m_HandPremiums;

		private bool m_RegulationVisible;

		protected override Type[] textIds => null;

		public bool isMobile => false;

		public bool isGamePad => false;

		public override void NotificationStackEntry()
		{
		}

		public static void Open(ViewControllerManager vc, Dictionary<string, object> args)
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

		private IEnumerator InitializeFiveDraw()
		{
			return null;
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
