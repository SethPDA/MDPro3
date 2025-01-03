using System.Collections.Generic;

namespace YgomGame.Duel
{
	public class EffectTaskBattleAttack : EffectTask
	{
		private enum Step
		{
			WaitCardMove = 0,
			WaitFinalBlow = 1,
			Finish = 2
		}

		private bool finished;

		private Step step;

		private int srcTeam;

		private int srcPosition;

		private int dstTeam;

		private int dstPosition;

		private bool tutorialFinished;

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

		public override bool Update()
		{
			return false;
		}

		public EffectTaskBattleAttack(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
			: base(null)
		{
		}

		private void WaitCardMoveStep()
		{
		}

		private void FinishStep()
		{
		}
	}
}
