using System.Collections.Generic;

namespace YgomGame.Duel
{
	public class EffectTaskRunSpecialefx : EffectTask
	{
		private enum EffectType
		{
			None = 0,
			InfiniteImpermanence = 1,
			EffectVeiler = 2
		}

		private enum Step
		{
			WaitLoad = 0,
			PlayEffect = 1,
			WaitEffect = 2,
			Finished = 3
		}

		private int cardID;

		private int param2;

		private int param3;

		private bool finished;

		private CardRunEffectSetting.CardRunEffectInfo cardRunEffectInfo;

		private EffectType effectType;

		private Step step;

		private static Dictionary<int, EffectType> spfxList;

		public static void MinimumEffect(RunEffectWorker worker, int param1, int param2, int param3)
		{
		}

		public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
		{
			return null;
		}

		public EffectTaskRunSpecialefx(RunEffectWorker worker, int param1, int param2, int param3)
			: base(null)
		{
		}

		public override bool Update()
		{
			return false;
		}

		private bool PlayEffectStep()
		{
			return false;
		}

		private void PlayInfiniteImtermanence()
		{
		}

		private void PlayEffectVeiler()
		{
		}

		private bool WaitEffectStep()
		{
			return false;
		}

		private void FinishedStep()
		{
		}
	}
}
