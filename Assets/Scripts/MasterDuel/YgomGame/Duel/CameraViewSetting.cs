using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Duel
{
	public class CameraViewSetting : ScriptableObject
	{
		[Serializable]
		public class ViewInfo
		{
			public string label;

			public Vector3 position;

			public Vector3 angle;

			public float fieldOfView;

			public float nearClip;

			public float farClip;

			public Quaternion rotation => default(Quaternion);

			public ViewInfo Copy()
			{
				return null;
			}
		}

		public List<ViewInfo> infoList;

		public static CameraViewSetting _instance;

		private static CameraViewSetting instance => null;

		public ViewInfo GetInfo(string label)
		{
			return null;
		}

		public static ViewInfo GetViewInfo(string label)
		{
			return null;
		}
	}
}
