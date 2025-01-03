using System.Collections.Generic;

namespace YgomGame.Duel
{
	public class EffectTaskHandOpen : EffectTask
	{
		private enum Step
		{
			None = 0,
			WaitCardMove = 1,
			WaitFlipTurn = 2,
			Finish = 3
		}

		private bool finished;

		private Step step;

		private int team;

		private bool isOpen;

		private int uniqueId;

		private bool isAll;

		private List<int> cardIds;

		private List<bool> cardFaces;

		public static Dictionary<string, object> PreCreate(RunEffectWorker worker, int param1, int param2, int param3)
		{
			return null;
		}

		public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
		{
			return null;
		}

		public EffectTaskHandOpen(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
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

		private void FinishStep()
		{
		}
	}
}
