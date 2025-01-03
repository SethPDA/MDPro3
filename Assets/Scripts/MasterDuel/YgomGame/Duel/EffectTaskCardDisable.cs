using System.Collections.Generic;

namespace YgomGame.Duel
{
	public class EffectTaskCardDisable : EffectTask
	{
		private enum Step
		{
			WaitInit = 0,
			WaitCardLoad = 1,
			Show = 2,
			Finish = 3
		}

		private bool finished;

		private CardShow cardShow;

		private SimpleEffect effAura;

		private int player;

		private int position;

		private int index;

		private int uniqueID;

		private int cardID;

		private bool face;

		private CardRoot cardRoot;

		private bool tempCard;

		private bool isAttacker;

		private Step step;

		public static Dictionary<string, object> PreCreate(RunEffectWorker worker, int param1, int param2, int param3)
		{
			return null;
		}

		public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
		{
			return null;
		}

		public EffectTaskCardDisable(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
			: base(null)
		{
		}

		public override bool Update()
		{
			return false;
		}

		private void StepWaitInit()
		{
		}

		private void WaitCardLoad()
		{
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
