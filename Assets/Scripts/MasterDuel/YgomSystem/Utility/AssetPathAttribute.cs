using System;
using UnityEngine;

namespace YgomSystem.Utility
{
	public class AssetPathAttribute : PropertyAttribute
	{
		public enum PathType
		{
			ResourceManager = 0,
			AssetDatabase = 1
		}

		public readonly Type assetType;

		public readonly PathType pathType;

		public AssetPathAttribute()
		{
		}

		public AssetPathAttribute(Type assetType)
		{
		}

		public AssetPathAttribute(Type assetType, PathType pathType)
		{
		}
	}
}
