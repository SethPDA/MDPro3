namespace YgomGame.Stats
{
	public class CardStatsData
	{
		public enum CARD_STATS_EFFECT_TYPE
		{
			CARD_STATS_EFFECT_TYPE_0 = 0,
			CARD_STATS_EFFECT_TYPE_1 = 1,
			CARD_STATS_EFFECT_TYPE_2 = 2,
			CARD_STATS_EFFECT_TYPE_MAX = 3
		}

		public int m_Item;

		public double m_fValue;

		public string m_Value;

		public CARD_STATS_EFFECT_TYPE m_EffectType;

		public string GetItemString()
		{
			return null;
		}

		public string GetItemUnitString()
		{
			return null;
		}

		public string GetValueString()
		{
			return null;
		}

		public CARD_STATS_EFFECT_TYPE GetValueEffectType()
		{
			return default(CARD_STATS_EFFECT_TYPE);
		}
	}
}
