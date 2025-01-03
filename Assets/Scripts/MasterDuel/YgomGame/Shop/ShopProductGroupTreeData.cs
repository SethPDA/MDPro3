using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Shop
{
	[Serializable]
	public class ShopProductGroupTreeData<T> : ShopProductGroupData where T : class, IShopProductGruopData
	{
		[SerializeField]
		private T[] m_Children;

		private Dictionary<int, T> m_ChildrenMap;

		public T[] children => null;

		public T GetGroupData(int groupId)
		{
			return null;
		}
	}
}
