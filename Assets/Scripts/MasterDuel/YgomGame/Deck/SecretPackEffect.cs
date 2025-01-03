using System;
using System.Collections;
using UnityEngine;
using YgomGame.Effect;

namespace YgomGame.Deck
{
	public class SecretPackEffect
	{
		private enum Step
		{
			Loading = 0,
			GetEffect = 1,
			ActiveEffect = 2,
			Finished = 3
		}

		private const string prefabPathGetSecret = "Prefabs/UI/DeckEdit/fxp_DeckEditUI/fxp_DeckEditUI_sctget_001";

		private const string prefabPathActiveSecret = "Prefabs/UI/DeckEdit/fxp_DeckEditUI/fxp_DeckEditUI_sctactive_001";

		private EffectHandler effectGetSecret;

		private EffectHandler effectActiveSecret;

		private Step step;

		public static SecretPackEffect Create(RectTransform targetButton, bool isMobile)
		{
			return null;
		}

		private void Initialize(RectTransform targetButton, bool isMobile)
		{
		}

		public void StartEffect(Action onPlayGetEffect)
		{
		}

		private IEnumerator UpdateCreateEffect(Action onPlayGetEffect)
		{
			return null;
		}

		public void DestroyGetEffect()
		{
		}

		public void Terminate()
		{
		}
	}
}
