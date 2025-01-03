using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomSystem.Utility
{
	//CreateAssetMenu]
	public class SpriteContainer : ScriptableObject
	{
		[Serializable]
		public class Container
		{
			public string label;

			public Sprite sprite;
		}

		public List<Container> containers;

		public UnityEngine.Object extraAsset;

		public Container GetContainer(string label)
		{
			return null;
		}

		public Sprite GetSprite(string label)
		{
			return null;
		}
	}
}
