using System.Collections.Generic;

namespace YgomGame.Duel
{
	public class EffectTaskMonstShuffle : EffectTask
	{
		private enum Step
		{
			WaitCardMove = 0,
			Wait = 1
		}

		private bool finished;

		private Step step;

		private int team;

		private int flag;

		private int callCounter;

		public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
		{
			return null;
		}

		public EffectTaskMonstShuffle(RunEffectWorker worker, int param1, int param2, int param3)
			: base(null)
		{
		}

		public override bool Update()
		{
			return false;
		}

		private void FlagToEachPlaces(int team, int flag, out List<BasicCardPlace> basicPlaces)
		{
			basicPlaces = null;
		}

		private void OnFinishedSwap()
		{
		}

		private void WaitCardMoveStep()
		{
		}
	}
}
