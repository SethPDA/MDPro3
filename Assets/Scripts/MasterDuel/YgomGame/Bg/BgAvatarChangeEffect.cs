using System;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame.Bg
{
	public class BgAvatarChangeEffect : MonoBehaviour
	{
		private Action delayCallback;

		private bool delayCheck;

		private float playtime;

		private float sePan;

		private ElementObjectManager manager;

		private ParticleSystem toMainObj;

		private ParticleSystem toSubObj;

		public float delay;

		public string toMainLabel;

		public string toSubLabel;

		public string toMainSELabel;

		public string toSubSELabel;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		public void PlayEffect(bool toMain, Action callback = null)
		{
		}

		public void TraceMainCameraSetting(Camera target)
		{
		}

		public void SetSePan(float pan)
		{
		}
	}
}
