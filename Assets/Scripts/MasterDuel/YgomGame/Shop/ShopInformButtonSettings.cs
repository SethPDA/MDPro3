using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Shop
{
	public class ShopInformButtonSettings : ScriptableObject
	{
		[Serializable]
		public class Data
		{
			[SerializeField]
			private string m_Label;

			[SerializeField]
			private ShopInformButtonData[] m_InfoButtonDatas;

			[SerializeField]
			private ShopInformButtonData[] m_InfoButtonMobileDatas;

			public string label => null;

			public ShopInformButtonData[] infoButtonDatas => null;

			public ShopInformButtonData[] infoButtonMobileDatas => null;

			public Data(string label)
			{
			}
		}

		internal const string k_Path = "Definition/Shop/ShopSettings";

		[SerializeField]
		private Data[] m_Datas;

		private Dictionary<string, Data> m_DataMap;

		public ShopInformButtonData[] Find(string label)
		{
			return null;
		}
	}
}
