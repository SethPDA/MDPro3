using System;
using System.Collections.Generic;
using UnityEngine;
using YgomSystem.UI;

namespace YgomSystem.Utility
{
	//[CreateAssetMenu]
	public class KeyCommandSetting : ScriptableObject
	{
		[Serializable]
		public class KeyCommandInfo
		{
			public string label;

			public List<SelectorManager.KeyType> keyList;
		}

		public List<KeyCommandInfo> infoList;

		public KeyCommandInfo Get(string label)
		{
			return null;
		}
	}
}
