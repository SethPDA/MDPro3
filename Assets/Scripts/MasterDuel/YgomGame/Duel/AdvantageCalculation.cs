using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomGame.Duel
{
	public class AdvantageCalculation : MonoBehaviour
	{
		private const int MAXPLAYERNUM = 4;

		public static int POINT_LEVEL_NORMAL;

		public static int POINT_LEVEL_EFFECT;

		public static int POINT_LEVEL_SYNC;

		public static int POINT_LEVEL_FUSION;

		public static int POINT_LEVEL_RITUAL;

		public static int POINT_LEVEL_PENDULUM;

		public static int POINT_LINK;

		public static int POINT_RANK;

		public static int POINT_OVERLAY;

		public static int POINT_MONSTER_NORMAL;

		public static int POINT_MONSTER_EFFECT;

		public static int POINT_MONSTER_LINK;

		public static int POINT_MONSTER_XYZ;

		public static int POINT_MONSTER_SYNC;

		public static int POINT_MONSTER_FUSION;

		public static int POINT_MONSTER_RITUAL;

		public static int POINT_MONSTER_PENDULUM;

		public static int POINT_MONSTER_OTHER;

		public static int POINT_MONSTER_STRONGEST;

		public static int POINT_TOKEN;

		public static int POINT_MAGIC_OHTER;

		public static int POINT_MAGIC_CONT;

		public static int POINT_MAGIC_EQUIP;

		public static int POINT_MAGIC_FIELD;

		public static int POINT_TRAP_OTHER;

		public static int POINT_TRAP_CONT;

		public static int POINT_SET;

		public static int POINT_HAND;

		public static int POINT_GRAVE;

		public static int POINT_EXCLUDED;

		public static int POINT_PENDULUM_IN_EXTRA;

		public static int POINT_PENDULUM_IN_PZONE_1;

		public static int POINT_PENDULUM_IN_PZONE_2;

		public static int POINT_PER_COUNTER;

		public static int POINT_PHASE_MAIN1;

		public static int POINT_PHASE_BATTLE;

		public static int POINT_PHASE_OTHER;

		public static int SAFELINE_REST_LP;

		public static int SAFELINE_REST_DECK;

		public static int SAFELINE_REST_TIME;

		private int[] pendCardCount;

		private int[] maxATK;

		private int[] maxDEF;

		public int[] PointOfNormalMonster
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

		public int[] PointOfEffectMonster
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

		public int[] PointOfRitualMonster
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

		public int[] PointOfFusionMonster
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

		public int[] PointOfSyncMonster
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

		public int[] PointOfXyzMonster
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

		public int[] PointOfPendMonster
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

		public int[] PointOfLinkMonster
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

		public int[] PointOfToken
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

		public int[] PointOfMagicCont
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

		public int[] PointOfMagicEquip
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

		public int[] PointOfMagicField
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

		public int[] PointOfMagicOther
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

		public int[] PointOfTrapCont
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

		public int[] PointOfTrapOther
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

		public int[] PointOfSetCard
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

		public int[] PointOfPendMagic
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

		public int[] PointOfExtra
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

		public int[] PointOfHand
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

		public int[] PointOfGrave
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

		public int[] PointOfExcluded
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

		public int[] PointOfLife
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

		public int[] PointOfStrongestMonster
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

		public int[] PointOfCounter
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

		public int[] PointOfPhase
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

		public float[] WeightOfDeck
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

		public float[] WeightOfLP
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

		public float[] WeightOfTime
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

		public static AdvantageCalculation Instance
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

		public static AdvantageCalculation Create(Transform parent)
		{
			return null;
		}

		public void EvaluateDuelPoint()
		{
		}

		private void EvaluateFieldCard(int player)
		{
		}

		private void ClearPoint(int player)
		{
		}

		public float GetPoint(int player)
		{
			return 0f;
		}

		private int CheckCardPoint(int player, int position)
		{
			return 0;
		}

		private int CheckMonsterCardPoint(int player, int position)
		{
			return 0;
		}

		private bool IsMinusCounter(Engine.CounterType type)
		{
			return false;
		}

		private int CheckCounter(int player, int position)
		{
			return 0;
		}

		private void UpdateMaxATKDEF(int player, int position)
		{
		}

		private int CheckStrongestMonster(int player)
		{
			return 0;
		}

		private int CheckMagicTrapCardPoint(int player, int position)
		{
			return 0;
		}

		private int CheckExtraDeck(int player)
		{
			return 0;
		}

		private int CheckPendulumZone(int player, int position)
		{
			return 0;
		}

		private int CheckHandCard(int player)
		{
			return 0;
		}

		private int CheckGraveCard(int player)
		{
			return 0;
		}

		private int CheckExcludedCard(int player)
		{
			return 0;
		}

		private int CheckPhase(int player)
		{
			return 0;
		}

		private bool CheckIfOTK(int player)
		{
			return false;
		}

		private void CheckDeck(int player)
		{
		}

		private void CheckRestLife(int player0)
		{
		}

		private int ErrorMsg(string msg)
		{
			return 0;
		}
	}
}
