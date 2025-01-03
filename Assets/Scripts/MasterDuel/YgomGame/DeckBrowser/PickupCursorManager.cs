using System.Collections.Generic;
using YgomSystem.ElementSystem;

namespace YgomGame.DeckBrowser
{
	public class PickupCursorManager
	{
		private Dictionary<int, PickupCursorWidget> dictSelectedCursor;

		private readonly string k_ELabelPickupCard0;

		private readonly string k_ELabelPickupCard1;

		private readonly string k_ELabelPickupCard2;

		private const int numPickups = 3;

		private int[] m_PickCardIds;

		private int[] m_PickPremiumIds;

		private int[] m_DeckCardIdx;

		private bool[] m_InitFlag;

		private int m_SelectedPickIdx;

		private bool isIni;

		private List<ElementObjectManager> m_PickupCardEoms;

		private List<DeckCardWidget> m_PickupCards;

		public int[] pickupCardIds => null;

		public int[] premiumIds => null;

		public int[] deckCardIdx => null;

		private int selectedPickId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool isMobile => false;

		private void ChangeSelectedId(int id)
		{
		}

		public PickupCursorManager(ElementObjectManager eom, int[] mrks, int[] premiums, int protectorId)
		{
		}

		private void InitializePickups(int[] mrks, int[] premiums, int protectorId)
		{
		}

		public void SetPickup(PickupCursorWidget pickupCursor, int mrk, int premiumId, int deckIdx)
		{
		}

		private void RemovePickup(int pickupId)
		{
		}

		public void UpdateCursor(PickupCursorWidget pickupCursor, int mrk, int premiumId, int pickupId = 0, int deckIdx = -1, bool notRemove = false)
		{
		}

		public int CheckPickup(int mrk, int premiumId, int deckIdx)
		{
			return 0;
		}

		public int CheckPickupByDeckIdx(int deckIdx)
		{
			return 0;
		}

		internal void PickupCardsCallBacks(DeckBrowserViewController deckBrowser)
		{
		}
	}
}
