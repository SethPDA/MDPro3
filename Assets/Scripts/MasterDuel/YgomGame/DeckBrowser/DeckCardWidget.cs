using TMPro;
using UnityEngine.UI;
using YgomGame.Deck;
using YgomSystem.ElementSystem;

namespace YgomGame.DeckBrowser
{
	public class DeckCardWidget : DeckCard
	{
		private ElementObjectManager m_EomCache;

		private bool m_Ready;

		private bool m_IsMonochrome;

		private bool m_RagulationVisible;

		private bool m_RarityVisible;

		private const string k_ELabelGroupCardNum = "GroupCardNum";

		private const string k_ELabelTextCardNum = "TextCardNum";

		private Image m_CardNumBase;

		private TextMeshProUGUI m_CardNumText;

		public ElementObjectManager eom => null;

		public bool isMonochrome
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

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

		public bool rarityVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static DeckCardWidget Create(ElementObjectManager eom)
		{
			return null;
		}

		public void SetData(CardBaseData baseData)
		{
		}

		public void DispCardNum(bool b)
		{
		}

		public void SetCardNum(int num)
		{
		}

		private void OnFinishSetCardPicture()
		{
		}
	}
}
