using System.Collections.Generic;

namespace YgomGame.Duel
{
	public class EffectTaskRunList : EffectTask
	{
		private enum Step
		{
			WaitCardMove = 0,
			Finish = 1
		}

		private bool finished;

		private Step step;

		private int param1;

		private int param2;

		private int param3;

		private string text;

		public static Dictionary<string, object> PreCreate(RunEffectWorker worker, int param1, int param2, int param3)
		{
			return null;
		}

		public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
		{
			return null;
		}

		public EffectTaskRunList(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
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

		private void RunList(int iPlayer, int iType, int param)
		{
		}

		private void FinishStep()
		{
		}
	}
}
