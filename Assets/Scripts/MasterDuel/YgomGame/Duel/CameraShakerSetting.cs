using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Duel
{
	public class CameraShakerSetting : ScriptableObject
	{
		[Serializable]
		public class Info
		{
			public string label;

			public float duration;

			public float delay;

			public bool usePerlinShake;

			public float perlinCycle;

			public Vector3 perlinPower;

			public bool useCosShake;

			public float cosCycle;

			public Vector3 cosPower;

			public bool useSinShake;

			public float sinCycle;

			public Vector3 sinPower;

			public bool useSinShakeSub;

			public float sinCycleSub;

			public Vector3 sinPowerSub;

			public bool useRandomShake;

			public Vector3 randomMin;

			public Vector3 randomMax;

			public int randomDelayFrame;

			public float randomDelayGain;

			public Info Copy()
			{
				return null;
			}

			public (Vector3, bool) GetShake(float time, Vector3 pre_shake, int frame_count, Vector3 big, Vector3 lit)
			{
				return default((Vector3, bool));
			}
		}

		public List<Info> infoList;

		public Info Get(string label)
		{
			return null;
		}
	}
}
