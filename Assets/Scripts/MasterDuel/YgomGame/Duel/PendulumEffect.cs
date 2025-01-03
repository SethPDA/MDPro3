using System;
using UnityEngine;

namespace YgomGame.Duel
{
	public class PendulumEffect : SummonEffectBase
	{
		private Texture leftScaleSpriteOnes;

		private Texture leftScaleSpriteTens;

		private Texture rightScaleSpriteOnes;

		private Texture rightScaleSpriteTens;

		private Texture2D leftScaleTextureFront;

		private Material leftScaleTextureBack;

		private Texture2D rightScaleTextureFront;

		private Material rightScaleTextureBack;

		private int leftScale;

		private int rightScale;

		private const string SUMMON_PENDULUM = "Duel/Timeline/Duel/Universal/Summon/SummonPendulum/SummonPendulum01";

		public override Engine.SpSummonType spSummonType => default(Engine.SpSummonType);

		public static PendulumEffect Create()
		{
			return null;
		}

		public void LoadScaleCard(int leftCardID, int leftUniqueID, int leftScale, int rightCardID, int rightUniqueID, int rightScale)
		{
		}

		protected override bool PlayEffect(Action onFinished)
		{
			return false;
		}

		private void PlayPendulumEffect(int materialNum, Action onFinished)
		{
		}
	}
}
