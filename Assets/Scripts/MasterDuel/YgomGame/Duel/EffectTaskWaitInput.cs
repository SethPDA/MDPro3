using System.Collections.Generic;

namespace YgomGame.Duel
{
	public class EffectTaskWaitInput : EffectTask
	{
		private enum Step
		{
			WaitCardEffect = 0,
			WaitTutorial = 1,
			WaitInput = 2,
			WaitInputStart = 3,
			Finish = 4
		}

		private bool finished;

		private Step step;

		private Engine.MenuActType menuActType;

		private int param1;

		private int param2;

		private int param3;

		private string text;

		public const uint cmdBitHighlight = 2045u;

		public static Dictionary<string, object> PreCreate(RunEffectWorker worker, int param1, int param2, int param3)
		{
			return null;
		}

		public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
		{
			return null;
		}

		public EffectTaskWaitInput(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
			: base(null)
		{
		}

		public override bool Update()
		{
			return false;
		}

		private void OnDrawPhase(int param1, int param2, int param3)
		{
		}

		private void OnBattlePhase(int param1, int param2, int param3)
		{
		}

		private bool WaitCardEffect()
		{
			return false;
		}

		private void WaitInput()
		{
		}
	}
}
