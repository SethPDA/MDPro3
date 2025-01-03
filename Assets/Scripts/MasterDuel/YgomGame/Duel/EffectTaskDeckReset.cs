using System.Collections.Generic;

namespace YgomGame.Duel
{
	public class EffectTaskDeckReset : EffectTask
	{
		private enum Step
		{
			WaitCardMove = 0,
			Wait = 1
		}

		private bool isFinished;

		private Step step;

		private int team;

		private int position;

		private int deckNum;

		private Dictionary<string, object> immediateWork;

		public static Dictionary<string, object> PreCreate(RunEffectWorker worker, int param1, int param2, int param3)
		{
			return null;
		}

		public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
		{
			return null;
		}

		public EffectTaskDeckReset(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
			: base(null)
		{
		}

		public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
		{
			return null;
		}

		public EffectTaskDeckReset(RunEffectWorker worker, int param1, int param2, int param3)
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
	}
}
