using UnityEngine.UI;
using YgomGame.Card;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Deck
{
	public abstract class CardParameterWidget : CardBase
	{
		public SelectionButton m_BodyButton;

		protected CardIconSprites m_CardIconSprites;

		protected static Content m_cci => null;

		protected abstract Image m_AttrIcon { get; }

		protected abstract Image m_TunerIcon { get; }

		protected abstract Image m_PendScaleIcon { get; }

		protected abstract ExtendedTextMeshProUGUI m_PendScaleText { get; }

		protected abstract Image m_LvlIcon { get; }

		protected abstract ExtendedTextMeshProUGUI m_LvlText { get; }

		protected abstract Image m_RankIcon { get; }

		protected abstract ExtendedTextMeshProUGUI m_RankText { get; }

		protected abstract Image m_LinkIcon { get; }

		protected abstract ExtendedTextMeshProUGUI m_LinkText { get; }

		protected abstract Image m_TypeIcon { get; }

		protected abstract Image m_SpellTrapTypeIcon { get; }

		protected abstract Image m_RegulationIcon { get; }

		protected abstract Image m_RarityIcon { get; }

		protected void setRegulationIcon(int id)
		{
		}

		protected void setRegulationVisible(bool b)
		{
		}

		protected void setAttribute(bool b = true)
		{
		}

		protected void setTuner(bool b = true)
		{
		}

		protected void setPendulumScale(bool b = true)
		{
		}

		protected void setLevel(bool b = true)
		{
		}

		protected void setRank(bool b = true)
		{
		}

		protected void setLinkRating(bool b = true)
		{
		}

		protected void setType(bool b = true)
		{
		}

		protected void setSpellTrapType(bool b = true)
		{
		}

		protected void setRarity(bool b = true)
		{
		}
	}
}
