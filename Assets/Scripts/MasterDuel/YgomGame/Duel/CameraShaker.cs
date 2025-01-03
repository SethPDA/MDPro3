using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomGame.Duel
{
	public class CameraShaker : MonoBehaviour
	{
		public enum Type
		{
			LIFEDAMAGE = 0,
			ATTACKGUARD = 1,
			ATTACKBREAK = 2,
			ATTACKDIRECT = 3,
			ACEMONST1 = 4,
			ACEMONST2 = 5,
			ACEMONST3 = 6,
			EFFECT4354 = 7,
			EFFECT4342 = 8
		}

		public bool isShaking;

		private float shakeTimer;

		private Vector3 big;

		private Vector3 lit;

		private int loopCount;

		private string settingPath;

		private CameraShakerSetting setting;

		private CameraShakerSetting.Info shaker;

		public Vector3 shakeOffset
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool LoadSetting(string label)
		{
			return false;
		}

		public void Shake(Type type)
		{
		}

		public void Shake(string label)
		{
		}

		private void Update()
		{
		}

		private void UpdateShake(bool countup_time = true)
		{
		}

		public void FinishShake()
		{
		}
	}
}
