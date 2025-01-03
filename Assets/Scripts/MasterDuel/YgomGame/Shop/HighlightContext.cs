using System.Collections.Generic;

namespace YgomGame.Shop
{
	public class HighlightContext
	{
		private int m_ItemId;

		private Dictionary<string, object> m_HighlightData;

		public ShopDef.HighlightType highlightType => default(ShopDef.HighlightType);

		public bool supportedCard => false;

		public int mrk => 0;

		public int rare => 0;

		public int itemId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string path => null;

		public bool isPref => false;

		public bool isMate => false;

		public bool isSupportedPlay => false;

		public bool isSupportedMonsterCutin => false;

		public void Import(Dictionary<string, object> priceData)
		{
		}
	}
}
