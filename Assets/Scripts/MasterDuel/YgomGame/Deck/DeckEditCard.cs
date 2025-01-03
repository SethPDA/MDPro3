using UnityEngine.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Deck
{
	public class DeckEditCard : CardParameterWidget
	{
		protected const string LABEL_SBN_BODY = "ImageCard";

		private const string LABEL_IMG_ATTRIBUTEICON = "IconAttribute";

		private const string LABEL_IMG_LEVELICON = "IconLevel";

		private const string LABEL_TXT_LEVEL = "TextLevel";

		protected const string LABEL_IMG_REGULATIONICON = "IconLimit";

		private const string LABEL_IMG_LINKICON = "IconLink";

		private const string LABEL_TXT_LINK = "TextLink";

		private const string LABEL_IMG_PENDULUMICON = "IconPendulumScale";

		private const string LABEL_TXT_PENDULUM_SCALE = "TextPendulumScale";

		private const string LABEL_IMG_RANKICON = "IconRank";

		private const string LABEL_TXT_RANK = "TextRank";

		private const string LABEL_IMG_TUNERICON = "IconTuner";

		private const string LABEL_IMG_TYPEICON = "IconType";

		private const string LABEL_IMG_SPELLTRAPTYPEICON = "IconSpellTrapType";

		private const string LABEL_IMG_RARITYICON = "IconRarity";

		private Image AttrIcon;

		private Image TunerIcon;

		private Image PendScaleIcon;

		private ExtendedTextMeshProUGUI PendScaleText;

		private Image LvlIcon;

		private ExtendedTextMeshProUGUI LvlText;

		private Image RankIcon;

		private ExtendedTextMeshProUGUI RankText;

		private Image LinkIcon;

		private ExtendedTextMeshProUGUI LinkText;

		private Image TypeIcon;

		private Image SpellTrapTypeIcon;

		private Image RegulationIcon;

		private Image RarityIcon;

		private bool isIni;

		protected override Image m_AttrIcon => null;

		protected override Image m_TunerIcon => null;

		protected override Image m_TypeIcon => null;

		protected override Image m_SpellTrapTypeIcon => null;

		protected override Image m_PendScaleIcon => null;

		protected override ExtendedTextMeshProUGUI m_PendScaleText => null;

		protected override Image m_LvlIcon => null;

		protected override ExtendedTextMeshProUGUI m_LvlText => null;

		protected override Image m_RankIcon => null;

		protected override ExtendedTextMeshProUGUI m_RankText => null;

		protected override Image m_LinkIcon => null;

		protected override ExtendedTextMeshProUGUI m_LinkText => null;

		protected override Image m_RegulationIcon => null;

		protected override Image m_RarityIcon => null;

		protected new void InitializeElemnts()
		{
		}

		public virtual void SetData(CardBaseData baseData, int regulationID, DeckEditViewController2.DisplayMode mode = DeckEditViewController2.DisplayMode.Simple)
		{
		}

		public void ScalingIcons(float scale = 1.5f)
		{
		}
	}
}
