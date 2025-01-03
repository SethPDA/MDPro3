using System.Collections.Generic;

namespace YgomGame.Duel
{
	public class EffectTaskCardBreak : EffectTask
	{
		private enum Step
		{
			WaitCardRunEffect = 0,
			Finish = 1
		}

		private bool finished;

		private Step step;

		private int team;

		private int position;

		private int index;

		public static void MinimumEffect(RunEffectWorker worker, int param1, int param2, int param3)
		{
		}

		public static Dictionary<string, object> PreCreate(RunEffectWorker worker, int param1, int param2, int param3)
		{
			return null;
		}

		public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
		{
			return null;
		}

		public EffectTaskCardBreak(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
			: base(null)
		{
		}

		public override bool Update()
		{
			return false;
		}

		private void PlayBreakEffect()
		{
		}

		private void FinishStep()
		{
		}
	}
}
