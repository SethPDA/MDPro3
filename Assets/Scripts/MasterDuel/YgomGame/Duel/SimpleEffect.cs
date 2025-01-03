using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Duel
{
	public class SimpleEffect : DuelEffectHandle
	{
		private List<ParticleSystem> pss;

		private List<TrailRenderer> trs;

		private List<Animator> animators;

		private Dictionary<string, float[]> trailW;

		private Dictionary<ParticleSystem, float> defaultStartDelay;

		private float duration;

		private float time;

		private bool looping;

		public override bool isPlaying => false;

		public float delay
		{
			set
			{
			}
		}

		protected override void OnInitialize()
		{
		}

		protected virtual void OnInitializeImpl()
		{
		}

		protected override void OnTerminate()
		{
		}

		protected virtual void OnTerminateImpl()
		{
		}

		protected override void OnPlay()
		{
		}

		protected override void OnStop()
		{
		}

		protected override void OnUpdate()
		{
		}
	}
}
