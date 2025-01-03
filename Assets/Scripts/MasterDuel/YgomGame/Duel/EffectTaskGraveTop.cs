using System.Collections.Generic;

namespace YgomGame.Duel
{
	public class EffectTaskGraveTop : EffectTask
	{
		private enum Step
		{
			WaitCardMove = 0,
			WaitCardLoad = 1,
			WaitDeckTopMove = 2
		}

		private bool finished;

		private Step step;

		private int team;

		private int position;

		private int index;

		private int uniqueId;

		private int cardId;

		private bool face;

		private bool turn;

		private CardPlace cardPlace;

		private CardLocator noneLocator;

		private CardRoot cardRoot;

		public static Dictionary<string, object> PreCreate(RunEffectWorker worker, int param1, int param2, int param3)
		{
			return null;
		}

		public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
		{
			return null;
		}

		public EffectTaskGraveTop(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
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

		private void WaitCardLoadStep()
		{
		}

		private void OnFinished()
		{
		}
	}
}
