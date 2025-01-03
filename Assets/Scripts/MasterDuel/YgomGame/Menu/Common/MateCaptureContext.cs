using System;
using UnityEngine;

namespace YgomGame.Menu.Common
{
	[Serializable]
	public class MateCaptureContext
	{
		public int mateId;

		public Vector3 position;

		public Quaternion rotate;

		public Vector3 scale;

		public string settingPath;

		public GameObject locator;

		public int width;

		public int height;

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
