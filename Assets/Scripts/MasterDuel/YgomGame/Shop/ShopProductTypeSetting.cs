using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Shop
{
	//[CreateAssetMenu]
	public class ShopProductTypeSetting : ScriptableObject
	{
		[Serializable]
		public class Data
		{
			[SerializeField]
			private int m_ProductTypeId;

			[SerializeField]
			private int m_TargetCategoryId;

			[SerializeField]
			private bool m_TargetIsPeriod;

			[SerializeField]
			private bool m_HasSetItems;

			[SerializeField]
			private int m_LimitAlertSec;

			[SerializeField]
			private string m_InformButtonLabel;

			[SerializeField]
			private ShopDef.HighlightType m_HighlightType;

			[SerializeField]
			private ShopDef.ViewerLoopType m_ViewerLoopType;

			[SerializeField]
			private bool m_HideSummonPlay;

			public int productTypeId => 0;

			public int targetCategoryId => 0;

			public bool targetIsPeriod => false;

			public bool hasSetItems => false;

			public int limitAlertSec => 0;

			public string informButtonLabel => null;

			public ShopDef.HighlightType highlightType => default(ShopDef.HighlightType);

			public ShopDef.ViewerLoopType viewerLoopType => default(ShopDef.ViewerLoopType);

			public bool hideSummonPlay => false;
		}

		[SerializeField]
		private List<Data> m_Datas;

		private Dictionary<int, Dictionary<int, Dictionary<bool, Data>>> m_DataMap;

		public Data FindProductTypeData(ProductContext productContext)
		{
			return null;
		}

		public bool FindBoolData(ProductContext productContext, string key, bool defaultValue = false)
		{
			return false;
		}

		public int FindIntData(ProductContext productContext, string key, int defaultValue = 0)
		{
			return 0;
		}

		public string FindStringData(ProductContext productContext, string key, string defaultValue = null)
		{
			return null;
		}
	}
}
