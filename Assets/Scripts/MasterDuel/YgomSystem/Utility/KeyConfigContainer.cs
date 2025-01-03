using System;
using System.Collections.Generic;
using UnityEngine;
using YgomSystem.UI;

namespace YgomSystem.Utility
{
	//CreateAssetMenu]
	public class KeyConfigContainer : ScriptableObject
	{
		[Serializable]
		public class KeyConfig
		{
			public string label;

			public SelectorManager.KeyType keyTypeMain;

			public SelectorManager.KeyType keyTypeSub;
		}

		public List<KeyConfig> keyConfigList;

		public (SelectorManager.KeyType, SelectorManager.KeyType) GetKeyType(string label)
		{
			return default((SelectorManager.KeyType, SelectorManager.KeyType));
		}
	}
}
