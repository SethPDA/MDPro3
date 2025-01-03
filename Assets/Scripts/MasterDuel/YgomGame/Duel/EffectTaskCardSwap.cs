using System.Collections.Generic;

namespace YgomGame.Duel
{
	public class EffectTaskCardSwap : EffectTask
	{
		private enum Step
		{
			WaitCardMove = 0,
			WaitCamMove = 1,
			WaitSwap = 2
		}

		private bool finished;

		private Step step;

		private Engine.CardStatus from;

		private Engine.CardStatus to;

		private bool camMoved;

		private CardPlace fromPlace;

		private CardPlace toPlace;

		private CardRoot fromCardRoot;

		private CardRoot toCardRoot;

		private int fromCardID;

		private int fromUniqueID;

		private int toCardID;

		private int toUniqueID;

		public static Dictionary<string, object> PreCreate(RunEffectWorker worker, int param1, int param2, int param3)
		{
			return null;
		}

		public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
		{
			return null;
		}

		public EffectTaskCardSwap(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
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

		private void WaitCamMoveStep()
		{
		}

		private void WaitSwapStep()
		{
		}

		private void SetBackCardStatus(CardRoot cardRoot, int uniqueID, int cardID)
		{
		}

		private void ShowBackCardStatus(CardRoot cardRoot, Engine.CardStatus cardStatus)
		{
		}
	}
}
