using YgomSystem.UI;

namespace YgomGame.Duel
{
	public class EffectTaskRunCoin : EffectTask
	{
		private enum Step
		{
			WaitCardEffect = 0,
			WaitLoadEffect = 1,
			WaitCoin = 2,
			Finish = 3
		}

		private Step step;

		private ScreenSelector selector;

		private int numThrows;

		private int faceBits;

		private int shineBits;

		private bool isTimelineLoaded;

		public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
		{
			return null;
		}

		public EffectTaskRunCoin(RunEffectWorker worker, int param1, int param2, int param3)
			: base(null)
		{
		}

		public override bool Update()
		{
			return false;
		}

		private void WaitCardEffect()
		{
		}

		private void WaitCoin()
		{
		}

		public override void OnDestroy()
		{
		}
	}
}
