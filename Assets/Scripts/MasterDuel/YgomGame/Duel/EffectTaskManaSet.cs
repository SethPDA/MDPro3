using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Duel
{
	public class EffectTaskManaSet : EffectTask
	{
		private enum Step
		{
			WaitCardEffect = 0,
			WaitManaSet = 1,
			Finish = 2
		}

		private Vector3 anchor;

		private float timer;

		private const float waitTime = 0.5f;

		private Engine.CounterType counterType;

		private int dispCount;

		private int targetCount;

		private ManaSet manaSet;

		private Step step;

		public static Dictionary<string, object> PreCreate(RunEffectWorker worker, int param1, int param2, int param3)
		{
			return null;
		}

		public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
		{
			return null;
		}

		public EffectTaskManaSet(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
			: base(null)
		{
		}

		public override bool Update()
		{
			return false;
		}

		private void WaitCardEffectStep()
		{
		}

		private void WaitManaSetStep()
		{
		}
	}
}
