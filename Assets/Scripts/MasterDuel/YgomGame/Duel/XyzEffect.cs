using System;

namespace YgomGame.Duel
{
	public class XyzEffect : SummonEffectBase
	{
		public override Engine.SpSummonType spSummonType => default(Engine.SpSummonType);

		public static XyzEffect Create()
		{
			return null;
		}

		public override void Load(int destCardID, int destCardUniqueID, int[] materialCardIDs, int[] materialUniqueIDs, int materialNum, int destRareID, bool destIsMyself)
		{
		}

		protected override bool PlayEffect(Action onFinished)
		{
			return false;
		}

		private void PlayXyzEffect(int materialNum, Action onFinished)
		{
		}
	}
}
