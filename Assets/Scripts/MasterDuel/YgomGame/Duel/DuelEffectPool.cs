using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomGame.Duel
{
	public class DuelEffectPool : MonoBehaviour
	{
		private enum Step
		{
			Initializing = 0,
			Idle = 1,
			Terminating = 2
		}

		public enum Type
		{
			AffectRelative = 2,
			AttackDirect00 = 6,
			AttackDirect01 = 7,
			AttackGuard00 = 8,
			TargetingAiming = 10,
			CardActivate = 13,
			CardExplosion = 17,
			CardBreak = 18,
			CardDecide2 = 20,
			CardHappen = 21,
			CardDisable = 22,
			CardLockon00 = 23,
			ActiveCardAuraMiddle00 = 24,
			ActiveCardAuraMiddle01 = 25,
			CardMoveTrail01 = 27,
			DeckHighlight00 = 29,
			DrawArrow00 = 30,
			FieldIcon00 = 32,
			Invalid00 = 34,
			MaterialMonster = 35,
			SacrificeRun = 41,
			SacrificeTarget = 42,
			SummonPlane = 45,
			TapMonster = 49,
			HitNullSmall = 50,
			HitNullLargest = 53,
			HitLightSmall = 54,
			HitLightLargest = 57,
			HitDarkSmall = 58,
			HitDarkLargest = 61,
			HitWaterSmall = 62,
			HitWaterLargest = 65,
			HitFireSmall = 66,
			HitFireLargest = 69,
			HitEarthSmall = 70,
			HitEarthLargest = 73,
			HitWindSmall = 74,
			HitWindLargest = 77,
			CardDecide00 = 85,
			CardCrack00 = 86,
			AttackTrailNullLow = 87,
			AttackTrailNullHigh = 88,
			AttackTrailLightLow = 89,
			AttackTrailLightHigh = 90,
			AttackTrailDarkLow = 91,
			AttackTrailDarkHigh = 92,
			AttackTrailWaterLow = 93,
			AttackTrailWaterHigh = 94,
			AttackTrailFireLow = 95,
			AttackTrailFireHigh = 96,
			AttackTrailEarthLow = 97,
			AttackTrailEarthHigh = 98,
			AttackTrailWindLow = 99,
			AttackTrailWindHigh = 100,
			AttackTrailGodLow = 101,
			AttackTrailGodHigh = 102,
			AttackNullLow = 103,
			AttackNullHigh = 104,
			AttackLightLow = 105,
			AttackLightHigh = 106,
			AttackDarkLow = 107,
			AttackDarkHigh = 108,
			AttackWaterLow = 109,
			AttackWaterHigh = 110,
			AttackFireLow = 111,
			AttackFireHigh = 112,
			AttackEarthLow = 113,
			AttackEarthHigh = 114,
			AttackWindLow = 115,
			AttackWindHigh = 116,
			AttackGodLow = 117,
			AttackGodHigh = 118,
			DrawDrag = 122,
			DrawImpact = 123,
			ActiveCardAuraLow00 = 124,
			ActiveCardAuraLow01 = 125,
			ActiveCardAuraHigh00 = 126,
			ActiveCardAuraHigh01 = 127,
			LinkTargetCard = 131,
			SelectingCursorDeck = 132,
			SelectingCursorMonster = 133,
			SelectingCursorMagic = 134,
			SelectingCursorField = 135,
			ActiveMagicCardAuraHigh00 = 136,
			ActiveMagicCardAuraHigh01 = 137,
			CardExclude = 138,
			CardExcludeTrail = 139,
			CardBreakExcludeTrail = 140,
			CardReleaseTrail = 141,
			CardReleaseExcludeTrail = 142,
			FusionTargetCard = 143,
			SynchroTargetCard = 144,
			RitualTargetCard = 145,
			LandingLinkMiddle0 = 146,
			LandingLinkMiddle1 = 147,
			LandingLinkHigh0 = 148,
			LandingLinkHigh1 = 149,
			LandingFusionMiddle0 = 150,
			LandingFusionMiddle1 = 151,
			LandingFusionHigh0 = 152,
			LandingFusionHigh1 = 153,
			LandingPendulumMiddle0 = 154,
			LandingPendulumMiddle1 = 155,
			LandingPendulumHigh0 = 156,
			LandingPendulumHigh1 = 157,
			LandingAdvanceMiddle0 = 158,
			LandingAdvanceMiddle1 = 159,
			LandingAdvanceHigh0 = 160,
			LandingAdvanceHigh1 = 161,
			SelectTargetMonsterZone = 162,
			DecideTargetMonsterZone = 163,
			SelectTargetMagicZone = 164,
			DecideTargetMagicZone = 165,
			SelectTargetCard = 166,
			DecideTargetCard = 167,
			AttackTargetLine = 168,
			LandingSpSummonMiddle0 = 169,
			LandingSpSummonMiddle1 = 170,
			LandingSpSummonHigh0 = 171,
			LandingSpSummonHigh1 = 172,
			LandingMagic = 173,
			LandingSummonSmall = 174,
			EquipTargetLine = 175,
			LandingXyzMiddle0 = 176,
			LandingXyzMiddle1 = 177,
			LandingXyzHigh0 = 178,
			LandingXyzHigh1 = 179,
			LandingRitualMiddle0 = 180,
			LandingRitualMiddle1 = 181,
			LandingRitualHigh0 = 182,
			LandingRitualHigh1 = 183,
			LandingSynchroMiddle0 = 184,
			LandingSynchroMiddle1 = 185,
			LandingSynchroHigh0 = 186,
			LandingSynchroHigh1 = 187,
			DrawLimitedCardMove = 188,
			DrawLimitedCardImpact = 189,
			XyzMaterialIn = 190,
			XyzMaterialOut = 191,
			XyzMaterialTrail = 192,
			ActivateEffectExDeck = 193,
			ActivateEffectGrave = 194,
			ActivateEffectExclude = 195,
			SelectTargetDirectAttack = 196,
			DecideTargetDirectAttack = 197,
			HitGodSmall = 198,
			HitGodLargest = 199,
			CardVanish = 200,
			XyzMaterialAppear = 201,
			TutorialHighlight = 202,
			TutorialArrow = 203,
			TutorialUIHighlight = 204,
			LethalEffectNear = 205,
			LethalEffectFar = 206,
			HandDragLine = 207,
			CardRunEffectMugenHouyou = 208,
			CardRunEffectSkillDrain = 209,
			CardRunEffectSkillDrainCenter = 210,
			CardRunEffectLightningStorm = 211,
			CardRunEffectMugenHouyouCenter = 212,
			SpSummonEffect = 213,
			CardRunEffectHaruUrara = 214,
			LethalEffectDarkMagicianNear = 215,
			LethalEffectDarkMagicianFar = 216,
			CardRunEffectEffectVeiler = 217,
			LethalEffectBlueEyesNear = 218,
			LethalEffectBlueEyesFar = 219,
			LethalEffectRedEyesNear = 220,
			LethalEffectRedEyesFar = 221,
			AttackShootRedEyes = 222,
			CardApply = 223,
			ResidualEffectMugenHouyou = 224,
			Noop = 65535
		}

		private Step step;

		private Dictionary<Type, Queue<GameObject>> effects;

		private Dictionary<Type, List<DuelEffectHandle>> usingEffects;

		private List<Type> remainTypes;

		private Dictionary<Type, UnityEngine.Object> effSrcs;

		private List<GameObject> allEffects;

		private List<GameObject> usedEffects;

		private const string parentDir = "Duel/Effects";

		private static readonly Dictionary<Type, object[]> srcPaths;

		public bool isInitialized
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isTerminated
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public DuelGameObjectManager goManager
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static DuelEffectPool Create(DuelGameObjectManager goManager, GameObject root, string name)
		{
			return null;
		}

		private void Initialize()
		{
		}

		private void LoadEffects(Dictionary<Type, object[]> paths)
		{
		}

		public void Terminate()
		{
		}

		public void Inactivate()
		{
		}

		public T Use<T>(Type type, GameObject target, bool autoQuit, bool enableRestock = true, Action onFinished = null) where T : DuelEffectHandle
		{
			return null;
		}

		public SimpleEffect UseSimple(Type type, GameObject target, bool autoQuit, bool enableRestock = true, Action onFinished = null)
		{
			return null;
		}

		public void Unuse(Type type, DuelEffectHandle eff)
		{
		}

		private void Update()
		{
		}

		private void InitializingStep()
		{
		}

		private void IdleStep()
		{
		}

		private void TerminatingStep()
		{
		}

		private void Create(Type type, int numCreates)
		{
		}

		private void Enqueue(Type type, GameObject go)
		{
		}

		private GameObject Dequeue(Type type, bool enableRestock)
		{
			return null;
		}
	}
}
