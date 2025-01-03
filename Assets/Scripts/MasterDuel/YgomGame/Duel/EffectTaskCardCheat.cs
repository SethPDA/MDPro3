using System.Collections.Generic;

namespace YgomGame.Duel
{
	public class EffectTaskCardCheat : EffectTask
	{
		private enum Step
		{
			WaitCardMove = 0,
			WaitCamMove = 1,
			StartPlacement = 2,
			WaitSetCard = 3,
			WaitEffect = 4,
			Finish = 5
		}

		private bool finished;

		private Step step;

		private Engine.CardStatus st;

		private int cardId;

		private CardLocator cardLocator;

		private bool camMoved;

		private CardPlace cardPlace;

		private CardRoot cardRoot;

		private bool isFace;

		private bool waitEffect;

		private int uniqueID;

		public static Dictionary<string, object> PreCreate(RunEffectWorker worker, int param1, int param2, int param3)
		{
			return null;
		}

		public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
		{
			return null;
		}

		public EffectTaskCardCheat(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
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

		private void StartPlacementStep()
		{
		}

		private void WaitEffectStep()
		{
		}

		private void FinishStep()
		{
		}
	}
}
