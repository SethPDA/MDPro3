using YgomGame.Deck;
using YgomSystem.ElementSystem;

namespace YgomGame.DeckBrowser
{
	public class CardDetailWidget : CardDetailView
	{
		private ElementObjectManager m_EomCache;

		private bool m_RagulationVisible;

		private bool m_IsMobile;

		public ElementObjectManager eom => null;

		public bool regulationVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static CardDetailWidget Create(ElementObjectManager eom, bool isMobile = false)
		{
			return null;
		}

		public void SetCardByID(int id)
		{
		}

		public void SetPremiumID(int premiumId)
		{
		}

		public void SetRegulation(int reg)
		{
		}

		private void setNumPremiums()
		{
		}

		public void SetAsRental(int rentalPoolID, bool isRental, bool dispDismantleableText = false)
		{
		}

		private void Start()
		{
		}
	}
}
