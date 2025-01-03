using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.Duel;
using YgomGame.Effect;

namespace YgomGame.Deck
{
	public class CraftEffect
	{
		public enum Mode
		{
			Create = 0,
			Dismantle = 1
		}

		private enum Step
		{
			Loading = 0,
			CardEffect = 1,
			TrailEffect = 2,
			PointEffect = 3,
			Finished = 4
		}

		private Mode mode;

		private const string prefabPathCraftEffectCreateCard = "Prefabs/UI/DeckEdit/fxp_DeckEditUI/fxp_DeckEditUI_generate_001";

		private const string prefabPathCraftEffectDismantleCard = "Prefabs/UI/DeckEdit/fxp_DeckEditUI/fxp_DeckEditUI_dismantle_001";

		private const string prefabPathCraftEffectTrail = "Prefabs/UI/DeckEdit/fxp_DeckEditUI/fxp_DeckEditUI_trail_001";

		private const string prefabPathCraftEffectPoint = "Prefabs/UI/DeckEdit/fxp_DeckEditUI/fxp_DeckEditUI_point_001";

		private EffectHandler effectCard;

		private EffectHandler effectTrail;

		private EffectHandler effectPoint;

		private ChainedBezierMotion motion;

		private float time;

		private Step step;

		private Action onFinished;

		public static CraftEffect Create(Mode mode, Transform parent, RectTransform targetCard, RectTransform targetPoint, List<BezierMotionSetting> motionList, bool actionMenu)
		{
			return null;
		}

		private void Initialize(Mode mode, Transform parent, RectTransform targetCard, RectTransform targetPoint, List<BezierMotionSetting> motionList, bool actionMenu)
		{
		}

		public void StartEffect(Action onPlayPointEffect, Action onFinished)
		{
		}

		private IEnumerator UpdateCreateEffect(Action onPlayPointEffect)
		{
			return null;
		}

		private IEnumerator UpdateDismantleEffect(Action onPlayPointEffect)
		{
			return null;
		}

		public void Finish()
		{
		}
	}
}
