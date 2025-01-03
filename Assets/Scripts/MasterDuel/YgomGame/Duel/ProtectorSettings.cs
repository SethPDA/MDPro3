using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Duel
{
	//[CreateAssetMenu]
	public class ProtectorSettings : ScriptableObject
	{
		[Serializable]
		public class Info
		{
			public int protectorID;

			public float drawEffectIntensity;
		}

		private const string path = "Duel/ScriptableObject/ProtectorSettings";

		private static ProtectorSettings setting;

		public const float defaultDrawEffectIntensity = 0.3f;

		public List<Info> infoList;

		public float drawEffectIntensity;

		public static void Load(Action<ProtectorSettings> onLoaded)
		{
		}

		private Info GetInfoInternal(int protectorID)
		{
			return null;
		}

		private float GetDrawEffectIntensityInternal(int protectorID)
		{
			return 0f;
		}

		public static float GetDrawEffectIntensity(int protectorID)
		{
			return 0f;
		}
	}
}
