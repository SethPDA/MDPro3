using System.Collections.Generic;

namespace YgomGame.Duel
{
	public class EffectTaskTurnChange : EffectTask
	{
		private enum Step
		{
			WaitCardMove = 0,
			WaitEffects = 1,
			WaitFinish = 2
		}

		private Step step;

		private int team;

		private int player;

		private bool finished;

		private bool finishedAnime;

		private DuelStatusViewer.DuelStatusInfo statusInfo;

		public static void MinimumEffect(RunEffectWorker worker)
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

		public EffectTaskTurnChange(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
			: base(null)
		{
		}

		public override bool Update()
		{
			return false;
		}

		private void WaitCardMoveStep()
		{
		}

		private void WaitEffectsStep()
		{
		}
	}
}
