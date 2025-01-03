using System.Collections.Generic;

namespace YgomGame.Duel
{
	public class EffectTaskLifeDamage : EffectTask
	{
		private enum Step
		{
			WaitCardEffect = 0,
			WaitDamageEffect = 1,
			Finished = 2
		}

		private Step step;

		private int player;

		private int damage;

		private bool isPrev;

		private Engine.DamageType type;

		private int currentLP;

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

		public EffectTaskLifeDamage(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
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

		private void PlayDamageEffect()
		{
		}
	}
}
