using System.Collections.Generic;

namespace YgomGame.Duel
{
	public class EffectTaskCardHappen : EffectTask
	{
		private enum Step
		{
			WaitInit = 0,
			WaitTutorial = 1,
			InitCard = 2,
			WaitCardLoad = 3,
			Show = 4,
			Finish = 5
		}

		private enum HappenType
		{
			Happen = 0,
			Apply = 1
		}

		private int cardID;

		private int uniqueID;

		private int effectID;

		private int effectTextID;

		private int efxNo;

		private bool finished;

		private CardShow cardShow;

		private SimpleEffect effAura;

		private Engine.CardStatus st;

		private bool face;

		private CardRoot cardRoot;

		private bool tempCard;

		private bool isAttacker;

		private Step step;

		private HappenType happenType;

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

		public EffectTaskCardHappen(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
			: base(null)
		{
		}

		public override bool Update()
		{
			return false;
		}

		private bool StepWaitInit()
		{
			return false;
		}

		private void StepWaitTutorial()
		{
		}

		private bool StepInitCard()
		{
			return false;
		}

		private bool StepWaitCardLoad()
		{
			return false;
		}

		private void StepShow()
		{
		}

		private void OnInit()
		{
		}

		private void OnMove()
		{
		}

		private void OnWait()
		{
		}

		private void OnBack()
		{
		}

		private void OnFinish()
		{
		}
	}
}
