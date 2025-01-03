using System.Collections.Generic;

namespace YgomGame.Duel
{
	public class EffectTaskCardFlipTurn : EffectTask
	{
		private enum Step
		{
			WaitCardMove = 0,
			WaitSetCard = 1,
			StartMove = 2,
			WaitCamMove = 3,
			WaitFlipTurn = 4,
			WaitSummon = 5,
			Finish = 6
		}

		private enum ReasonType
		{
			CardEffect = 0,
			BattleAttack = 1,
			StandChange = 2,
			FlipSummon = 3,
			Look = 4
		}

		private bool finished;

		private Step step;

		private Engine.CardStatus st;

		private CardRoot cardRoot;

		private bool camMoved;

		private CardPlace cardPlace;

		private int cardId;

		private int uniqueID;

		private ReasonType reasonType;

		private bool isReverse;

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

		public EffectTaskCardFlipTurn(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
			: base(null)
		{
		}

		public override void OnDestroy()
		{
		}

		public override bool Update()
		{
			return false;
		}

		private void FinishStep()
		{
		}

		private void WaitCardMoveStep()
		{
		}

		private void WaitSetCardStep()
		{
		}

		private void StartMoveStep()
		{
		}

		private void WaitCamMoveStep()
		{
		}
	}
}
