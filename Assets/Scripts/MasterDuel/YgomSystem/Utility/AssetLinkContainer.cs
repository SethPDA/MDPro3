using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomSystem.Utility
{
	//[CreateAssetMenu]
	public class AssetLinkContainer : ScriptableObject
	{
		[Serializable]
		public class Container
		{
			public string label;

			public string assetPath;

			public Container Copy()
			{
				return null;
			}
		}

		public List<Container> containers;

		public virtual Container GetContainer(string label)
		{
			return null;
		}

		public void GetAsset(string label, Action<UnityEngine.Object> onFinished, Type systemTypeInstance = null)
		{
		}
	}
}
