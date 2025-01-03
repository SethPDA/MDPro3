using System;
using UnityEngine;

namespace YgomGame.Shop
{
	[Serializable]
	public class ShopProductGroupData : IShopProductGruopData
	{
		private readonly string k_NobrFormat;

		[SerializeField]
		private int m_GroupId;

		[SerializeField]
		private string m_LabelTextId;

		[SerializeField]
		private bool m_LabelNobr;

		[SerializeField]
		private bool m_Constant;

		[SerializeField]
		private string m_ProductWidgetLabel;

		[SerializeField]
		private int m_BgId;

		[SerializeField]
		private bool m_SkipSoldoutSort;

		[SerializeField]
		private bool m_IsShortPayAmountSort;

		[SerializeField]
		private bool m_IgnoreTurnoffBadge;

		public int groupId => 0;

		public string labelTextId => null;

		public virtual string labelText => null;

		public bool constant => false;

		public virtual bool IsMatchProduct(ProductContext product)
		{
			return false;
		}

		public bool FindBoolData(string key, bool defaultValue = false)
		{
			return false;
		}

		public int FindIntData(string key, int defaultValue = 0)
		{
			return 0;
		}

		public string FindStringData(string key, string defaultValue = null)
		{
			return null;
		}
	}
}
