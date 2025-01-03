using System.Collections.Generic;

namespace YgomGame.Duel
{
	public class EffectTaskDeckFlipTop : EffectTask
	{
		private enum Step
		{
			WaitCardMoving = 0,
			WaitCardLoading = 1,
			Wait = 2
		}

		private bool finished;

		private Step step;

		private int team;

		private int position;

		private bool isOpen;

		private int index;

		private int uniqueId;

		private int cardId;

		private DeckCardPlace deckPlace;

		private CardRoot cardRoot;

		public static Dictionary<string, object> PreCreate(RunEffectWorker worker, int param1, int param2, int param3)
		{
			return null;
		}

		public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
		{
			return null;
		}

		public EffectTaskDeckFlipTop(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
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

		private void WaitCardLoadingStep()
		{
		}

		private void StartMove()
		{
		}
	}
}
