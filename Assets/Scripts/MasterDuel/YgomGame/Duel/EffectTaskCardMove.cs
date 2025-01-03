using System.Collections.Generic;

namespace YgomGame.Duel
{
	public class EffectTaskCardMove : EffectTask
	{
		private enum Step
		{
			WaitCardMove = 0,
			WaitLoadCard = 1,
			WaitSetCard = 2,
			StartMove = 3,
			WaitMove = 4,
			Finish = 5
		}

		public enum LandingType
		{
			NORMAL = 0,
			SUMMON_LOW = 1,
			SUMMON_MIDDLE = 2,
			SUMMON_HIGH = 3,
			MAGIC = 4,
			MAGIC_SET = 5
		}

		public enum SummonEffectType
		{
			None = 0,
			Advance = 1,
			Fusion = 2,
			Ritual = 3,
			Synchro = 4,
			Xyz = 5,
			Pendulum = 6,
			Link = 7
		}

		public struct LandingEffectInfo
		{
			public bool useEffect;

			public DuelEffectPool.Type effectType;

			public bool useEffectImpact;

			public DuelEffectPool.Type effectTypeImpact;

			public bool useEffectSummon;

			public DuelEffectPool.Type effectTypeSummon;

			public string shakeLabel;

			public string seLabel;

			public float effectTime;
		}

		private bool finished;

		private Step step;

		private Engine.CardStatus from;

		private Engine.CardStatus to;

		private Engine.CardMoveType moveType;

		private int uniqueId;

		private int cardId;

		private int toTopUniqueID;

		private int fromTopUniqueID;

		private int directFlag;

		private CardRoot cardRoot;

		private bool camMoved;

		private CardPlace fromPlace;

		private CardPlace toPlace;

		private BezierMotionSetting[] motionList;

		private string motionSeCode;

		private bool toFace;

		private CardLocator fromLocator;

		private CardLocator toLocator;

		private CardLocator summonLocator;

		private CardRoot.ModelType toModelType;

		private CardRoot.ModelType fromModelType;

		private bool isSoul;

		private LandingType landingType;

		private bool moveFromScreenCenter;

		private bool isAttacker;

		private bool isAttackTarget;

		private int attackerPlayer;

		private int attackerPosition;

		private int attackTargetPlayer;

		private int attackTargetPosition;

		private SummonEffectBase summonEffect;

		private bool waitZoneEffect;

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

		public EffectTaskCardMove(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
			: base(null)
		{
		}

		public override bool Update()
		{
			return false;
		}

		private bool WaitCardMoveStep()
		{
			return false;
		}

		private bool WaitLoadCardStep()
		{
			return false;
		}

		private bool StartMoveStep()
		{
			return false;
		}

		private void CommonMove()
		{
		}

		private void OnFinished()
		{
		}

		private void FinishStep()
		{
		}

		private LandingType GetLandingType()
		{
			return default(LandingType);
		}

		public static LandingEffectInfo GetLandingEffectInfo(LandingType landingType, SummonEffectType summonEffectType, Engine.CardMoveType moveType)
		{
			return default(LandingEffectInfo);
		}

		private void ReqLandingEffect()
		{
		}

		private bool IsSamePosition(int positionA, int positionB)
		{
			return false;
		}
	}
}
