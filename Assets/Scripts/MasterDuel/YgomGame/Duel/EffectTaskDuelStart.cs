using System.Collections.Generic;

namespace YgomGame.Duel
{
	public class EffectTaskDuelStart : EffectTask
	{
		private enum Step
		{
			PlayEachPlayer = 0,
			WaitEachPlayer = 1,
			Finish = 2,
			Tutorial = 3
		}

		private enum CharaStep
		{
			Entry = 0,
			Wait = 1,
			Finish = 2
		}

		private bool finished;

		private Step step;

		private bool charaFinished;

		private CharaStep charaStep;

		public static Dictionary<string, object> PreCreate(RunEffectWorker worker, int param1, int param2, int param3)
		{
			return null;
		}

		public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
		{
			return null;
		}

		public EffectTaskDuelStart(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
			: base(null)
		{
		}

		public override bool Update()
		{
			return false;
		}

		private void PlayEachPlayerStep()
		{
		}

		private void FinishStep()
		{
		}

		private void WaitCharaStep()
		{
		}

		private void FinishCharaStep()
		{
		}
	}
}
