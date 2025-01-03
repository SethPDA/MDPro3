using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Shop
{
	public class ShopCardThumbSettingLoader : MonoBehaviour
	{
		private static ShopCardThumbSettingLoader s_Instance;

		private ShopCardThumbSettings m_Setting;

		private List<(GameObject, Action<ShopCardThumbSettings>)> m_Requests;

		[SerializeField]
		private List<GameObject> m_Referer;

		public static void Load(GameObject owner, Action<ShopCardThumbSettings> callback)
		{
		}

		public static void Unload(GameObject owner)
		{
		}
	}
}
