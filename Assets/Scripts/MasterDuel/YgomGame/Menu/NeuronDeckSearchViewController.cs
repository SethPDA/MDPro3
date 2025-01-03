using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomSystem.UI;
using YgomSystem.Utility;

namespace YgomGame.Menu
{
	public class NeuronDeckSearchViewController : PublicDeckSearchController
	{
		private readonly string k_ELabelDeckNumValue;

		private readonly string k_ELabelTextDeckNumValue;

		private readonly string k_ELabelNeuronDecksHelpButton;

		private readonly string k_ELabelOpenNeuronDecksButton;

		private readonly string k_ELabelNeuronLogoBG;

		private readonly string k_ELabelNeuronLogoIconBG;

		private Transform m_DeckNumValue;

		private TextMeshProUGUI m_TextDeckNumValue;

		private SelectionButton m_NeuronDecksHelpButton;

		private SelectionButton m_OpenNeuronDecksButton;

		private Transform m_NeuronLogoBG;

		private Image m_NeuronLogoIconBG;

		[SerializeField]
		private SpriteContainer m_BackGroundContainer;

		private readonly string k_LabelJpLogo;

		private readonly string k_LabelUniversalLogo;

		private readonly string k_LabelKoLogo;

		private const string GROUP_LABEL = "NeuronMyDeck";

		protected override Type[] textIds => null;

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		protected override void UpdateDecks()
		{
		}

		protected override void OnClickPublicDeck(string cardgameId, int deckNo, int pickCardId)
		{
		}

		public override void OpenDeckBrowser(string cardgameId, int deckNo, int pickCardId)
		{
		}

		protected override IEnumerator Initialize()
		{
			return null;
		}

		protected override IEnumerator AdditionalDeckDataLoad()
		{
			return null;
		}

		public override void OnItemSetData(GameObject gob, int dataindex)
		{
		}

		private void GetNeuronToken(UnityAction getTokenEvent)
		{
		}

		public IEnumerator DeckSearch_Search(int requestPageNo = 0, bool isFirst = false)
		{
			return null;
		}

		private void DeckSearch_Detail(string targetId, int deckNo, int pickCardId, bool isFirst = false)
		{
		}

		private void OpenCautionMMA()
		{
		}

		protected override void OpenMaintenanceDialog()
		{
		}
	}
}
