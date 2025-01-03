using System;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.Card;

namespace YgomGame.Duel
{
	public class BattleRunAttackSetting : ScriptableObject
	{
		[Serializable]
		public class DefaultMotionType
		{
			public Content.Attribute keyAttribute;

			public EffectTaskBattleRun.AttackType attackType;

			public DefaultMotionType Copy()
			{
				return null;
			}
		}

		[Serializable]
		public class CardMotionType
		{
			public int cardID;

			public EffectTaskBattleRun.AttackType attackType;

			public LethalEffect.EffectType lethalEffectType;

			public CardMotionType Copy()
			{
				return null;
			}
		}

		public List<DefaultMotionType> defaultMotionSettings;

		public List<CardMotionType> cardMotionSettings;

		public EffectTaskBattleRun.AttackType GetDefaultAttackType(Content.Attribute attribute)
		{
			return default(EffectTaskBattleRun.AttackType);
		}

		public EffectTaskBattleRun.AttackType GetCardAttackType(int card_id)
		{
			return default(EffectTaskBattleRun.AttackType);
		}

		public LethalEffect.EffectType GetCardLethaEffectType(int card_id)
		{
			return default(LethalEffect.EffectType);
		}
	}
}
