using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using YgomGame.Card;

namespace YgomGame.Duel
{
	public class EffectTaskBattleRun : EffectTask
	{
		private enum Step
		{
			LoadMotion = 0,
			WaitCardMove = 1,
			LoadSE = 2,
			AttackInit = 3,
			AttackMove = 4,
			AttackBack = 5,
			Lethal = 6,
			Finish = 7
		}

		public struct AttackEffectInfo
		{
			public bool isFinished;

			public int srcTeam;

			public int srcPosition;

			public int dstTeam;

			public int dstPosition;

			public int attackLevel;

			public bool isDirectAttack;

			public bool isSrcLethal;

			public bool isDstLethal;

			public Vector3 attackTargetPos;

			public Vector3 attackDefaultPos;

			public Quaternion attackDefaultRot;

			public Vector3 attackTargetHandPos;

			public Vector3 attackSrcHandPos;

			public bool isStart;

			public bool isTrail;

			public bool isAttack;

			public bool isHit;

			public bool isShoot;

			public bool[] timelinePlayed;

			public PlayableDirector[] playingTimeline;

			public SimpleEffect shootEffect;

			public Vector3 shootOriginPosition;

			public Vector3 shootTargetPosition;

			public Quaternion shootOriginRotation;

			public Quaternion shootTargetRotation;

			public ChainedBezierMotion shootMotion;

			public bool isLethal => false;
		}

		public enum AttackType
		{
			Strike = 0,
			Flash = 1,
			Shoot = 2,
			Unknown = 3
		}

		private bool hitEffect;

		private Step step;

		private float time;

		private CardRoot cardRoot;

		private int[] damages;

		private int prop;

		private int srcDamage;

		private int dstDamage;

		private bool isSrcBreak;

		private bool isDstBreak;

		private bool isSrcDamage;

		private bool isDstDamage;

		private AttackEffectInfo attackEffectInfo;

		private Content.Attribute attribute;

		public const float hitEffectOfsH = 3f;

		public static readonly Vector3 hitEffectOffset;

		private ChainedBezierMotion runMotion;

		private AttackMotionSetting.MotionInfo motionInfo;

		private int motionIndex;

		private const string BattleRunAttackSettingPath = "Duel/ScriptableObject/BattleRunAttackSetting";

		private const string AttackMotionSettingPath = "Duel/ScriptableObject/AttackMotionSetting";

		private int loadCounter;

		private BattleRunAttackSetting attackSetting;

		private LethalEffect.EffectType lethalEffectType;

		private float attackExecPostTime => 0f;

		public static Dictionary<string, object> PreCreate(RunEffectWorker worker, int param1, int param2, int param3)
		{
			return null;
		}

		public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
		{
			return null;
		}

		public EffectTaskBattleRun(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
			: base(null)
		{
		}

		public override bool Update()
		{
			return false;
		}

		private void LoadMotion()
		{
		}

		private static string GetMotionLabel(AttackType attack_type, Content.Attribute attribute, Util.AttackLevel attackLevel, LethalEffect.EffectType effectType, bool isDirect)
		{
			return null;
		}

		public static AttackMotionSetting.MotionInfo GetMotionInfo(AttackMotionSetting setting, AttackType attack_type, Content.Attribute attribute, Util.AttackLevel attackLevel, LethalEffect.EffectType effectType, bool isDirect)
		{
			return null;
		}

		private void WaitCardMoveStep()
		{
		}

		private void LoadSEStep()
		{
		}

		private void AttackInitStep()
		{
		}

		private void AttackMoveStep()
		{
		}

		public static AttackEffectInfo AttackMove(CardRoot cardRoot, ChainedBezierMotion runMotion, AttackMotionSetting.MotionInfo motionInfo, int motionIndex, float time, AttackEffectInfo attackEffectInfo, DuelEffectPool effectPool)
		{
			return default(AttackEffectInfo);
		}

		private static AttackEffectInfo PlayTrailEffect(CardRoot cardRoot, AttackEffectInfo attackEffectInfo, AttackMotionSetting.MotionInfo motionInfo)
		{
			return default(AttackEffectInfo);
		}

		private static AttackEffectInfo PlayAttackEffect(CardRoot cardRoot, AttackEffectInfo attackEffectInfo, AttackMotionSetting.MotionInfo motionInfo, DuelEffectPool effectPool)
		{
			return default(AttackEffectInfo);
		}

		private static AttackEffectInfo PlayHitEffect(CardRoot cardRoot, AttackEffectInfo attackEffectInfo, AttackMotionSetting.MotionInfo motionInfo, DuelEffectPool effectPool)
		{
			return default(AttackEffectInfo);
		}

		private static AttackEffectInfo PlayShootEffect(CardRoot cardRoot, AttackEffectInfo attackEffectInfo, AttackMotionSetting.MotionInfo motionInfo, DuelEffectPool effectPool)
		{
			return default(AttackEffectInfo);
		}

		public static AttackEffectInfo PlayTimeline(Transform card, Transform defaultParent, bool isMyself, AttackEffectInfo attackEffectInfo, AttackMotionSetting.MotionInfo motionInfo, int timelineIndex)
		{
			return default(AttackEffectInfo);
		}

		public static AttackEffectInfo UpdateTimeline(Transform card, AttackEffectInfo attackEffectInfo, AttackMotionSetting.MotionInfo motionInfo, int timelineIndex)
		{
			return default(AttackEffectInfo);
		}

		private static int GetAttackLevel(CardRoot cardRoot, bool includeNoDamage, bool isBreak, bool isDamage, int targetPlayer)
		{
			return 0;
		}

		private Content.Attribute GetAttackAttribute(short element)
		{
			return default(Content.Attribute);
		}

		private void ShowDamage()
		{
		}

		private void ShowDamageImpl(int team, int position, int damage)
		{
		}

		private void SetCardLayer(int layer)
		{
		}
	}
}
