using System.Collections.Generic;

namespace YgomGame.Duel
{
	public class EffectTaskCutinActivate : EffectTask
	{
		private enum Step
		{
			Finish = 0
		}

		private Step step;

		private bool finished;

		private int player;

		private int mixedId;

		private int owner;

		private int state;

		private int cardId;

		private int type;

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

		public EffectTaskCutinActivate(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
			: base(null)
		{
		}

		public override bool Update()
		{
			return false;
		}

		private void FinishStep()
		{
		}
	}
}
