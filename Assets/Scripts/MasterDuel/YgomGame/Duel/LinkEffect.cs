using System;
using System.Collections.Generic;

namespace YgomGame.Duel
{
	public class LinkEffect : SummonEffectBase
	{
		private List<int> linkMarker;

		public override Engine.SpSummonType spSummonType => default(Engine.SpSummonType);

		public static LinkEffect Create()
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

		private void PlayLinkEffect(int materialNum, Action onFinished)
		{
		}
	}
}
