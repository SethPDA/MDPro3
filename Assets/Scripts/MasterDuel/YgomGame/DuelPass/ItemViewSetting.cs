using System;
using UnityEngine;

namespace YgomGame.Duelpass
{
	[Serializable]
	public class ItemViewSetting
	{
		public int itemId;

		public Vector3 localPosition;

		public Vector3 eulerAngles;

		public Vector3 localScale;

		public ItemViewSetting(int itemId, Transform transform)
		{
		}
	}
}
