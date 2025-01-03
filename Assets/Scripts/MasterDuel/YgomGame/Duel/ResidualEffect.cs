using System.Collections.Generic;
using UnityEngine;

namespace YgomGame.Duel
{
	public class ResidualEffect
	{
		public class EffectInfo
		{
			public SimpleEffect effectObj;
		}

		public class PrepareInfo
		{
			public DuelEffectPool.Type type;

			public int player;

			public int position;
		}

		private DuelEffectPool pool;

		private List<EffectInfo> effects;

		private List<PrepareInfo> prepareInfoList;

		public static ResidualEffect Create(DuelEffectPool pool)
		{
			return null;
		}

		public EffectInfo Play(DuelEffectPool.Type type, Vector3 position)
		{
			return null;
		}

		public void OnTurnEnd()
		{
		}

		private void StopAllEffects()
		{
		}

		public void Terminate()
		{
		}

		public void Prepare(DuelEffectPool.Type type, int player, int position)
		{
		}

		public void PlayPreparedEffect(DuelFieldBase duelField)
		{
		}

		public void CancelPreareEffect()
		{
		}
	}
}
