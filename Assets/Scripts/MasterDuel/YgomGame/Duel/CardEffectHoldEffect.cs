namespace YgomGame.Duel
{
	public class CardEffectHoldEffect : CardEffectBase
	{
		public enum Mode
		{
			TracePosition = 0,
			TracePosture = 1,
			ChildPosture = 2,
			ChildPosition = 3
		}

		private string label;

		private DuelEffectPool.Type type;

		private Mode mode;

		private bool show;

		private bool quitImmediate;

		public static CardEffectHoldEffect CreateShowEffect(CardRoot cardRoot, string label, DuelEffectPool.Type type, Mode mode)
		{
			return null;
		}

		public static CardEffectHoldEffect CreateHideEffect(CardRoot cardRoot, string label, bool quitImmediate)
		{
			return null;
		}

		public override void StartEffect()
		{
		}
	}
}
