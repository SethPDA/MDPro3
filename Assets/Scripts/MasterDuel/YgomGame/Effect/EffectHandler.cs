using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomGame.Effect
{
	public class EffectHandler : MonoBehaviour
	{
		private ParticleSystem[] particles;

		private TrailRenderer[] trails;

		private bool autoDestroy;

		private Action onFinishedCallback;

		public bool isPlaying
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static void Create(string path, Transform parent, Action<EffectHandler> onLoadedCallback, bool autoDestroy)
		{
		}

		public static EffectHandler Create(GameObject target, bool autoDestroy)
		{
			return null;
		}

		private void Awake()
		{
		}

		public void Setup()
		{
		}

		public void Play(Action onFinishedCallback)
		{
		}

		private bool IsPlaying()
		{
			return false;
		}

		public void Stop()
		{
		}

		private void Update()
		{
		}

		public void SetDisp(bool disp)
		{
		}
	}
}
