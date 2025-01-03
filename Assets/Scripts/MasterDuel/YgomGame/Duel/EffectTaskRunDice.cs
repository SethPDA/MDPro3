using YgomSystem.UI;

namespace YgomGame.Duel
{
	public class EffectTaskRunDice : EffectTask
	{
		private enum Step
		{
			WaitCardEffect = 0,
			WaitDice = 1,
			Finish = 2
		}

		private int team;

		private int numThrows;

		private int number;

		private ScreenSelector selector;

		private bool isSkip;

		private bool isTimelineLoaded;

		private Step step;

		public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
		{
			return null;
		}

		public EffectTaskRunDice(RunEffectWorker worker, int param1, int param2, int param3)
			: base(null)
		{
		}

		public override bool Update()
		{
			return false;
		}

		private void WaitCardEffectStep()
		{
		}

		private void WaitDiceStep()
		{
		}

		public override void OnDestroy()
		{
		}
	}
}
