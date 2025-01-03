using System;
using UnityEngine;

namespace YgomGame.Menu.Common
{
	[Serializable]
	public class BindingWallpaperContext
	{
		[SerializeField]
		public int id;

		[SerializeField]
		public int width;

		[SerializeField]
		public int height;

		[SerializeField]
		public BindingGameObjectEx.FitMode fitMode;

		[SerializeField]
		public bool useImage;

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
