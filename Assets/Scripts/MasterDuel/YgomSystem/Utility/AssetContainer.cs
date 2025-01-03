using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomSystem.Utility
{
	//[CreateAssetMenu]
	public class AssetContainer : ScriptableObject
	{
		[Serializable]
		public class Container
		{
			public string label;

			public UnityEngine.Object asset;
		}

		public List<Container> containers;

		public Container GetContainer(string label)
		{
			return null;
		}

		public UnityEngine.Object GetAsset(string label)
		{
			return null;
		}

		public T GetAsset<T>(string label) where T : UnityEngine.Object
		{
			return null;
		}
	}
}
