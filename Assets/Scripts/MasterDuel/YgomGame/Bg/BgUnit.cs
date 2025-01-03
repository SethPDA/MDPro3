using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using YgomGame.Duel;

namespace YgomGame.Bg
{
	public class BgUnit
	{
		public enum Side
		{
			Near = 0,
			Far = 1
		}

		public enum BgPhase
		{
			Phase1 = 0,
			Phase2 = 1,
			Phase3 = 2,
			Phase4 = 3,
			PhaseEnd = 4
		}

		public enum BgResourceIdx
		{
			BgModel = 0,
			AvatarStand = 1,
			Grave = 2,
			AvatarBase = 3,
			AvatarModel = 4,
			SubAvatarModel = 5,
			ChangeEffect = 6,
			Max = 7
		}

		public enum AvatarStandType
		{
			None = 0,
			Common = 1,
			Unique = 2
		}

		private BgEffectSettingInner.TriggerLabelDefine[] damageTriggerDefines;

		private BgEffectSettingInner.TriggerLabelDefine[] phaseChangeDefines;

		private BgEffectManagerInner.BgAnimationEventParam[] eventParams;

		private BgEffectSettingInner.TriggerLabelDefine[] phaseKeepDefines;

		private BgEffectSettingInner.AnimationLabelDefine[] loopDefines;

		private BgEffectSettingInner.AnimationLabelDefine[] tapPhaseDefines;

		private const float avatarSePan = 0.4f;

		private Side playerSide;

		private int bgNo;

		private string bgSeLabel;

		private string[] bgResPath;

		private GameObject[] bgModelSrc;

		private GameObject bgModel;

		private BgEffectManagerInner effectManager;

		private GameObject avatarStandModel;

		private int graveNo;

		private BgGrave.GraveType graveType;

		public BgGrave bgGrave;

		private int loadCount;

		public bool isErrModelSrc;

		public bool bgResLoaded;

		private BgPhase phase;

		public Transform avatarStandRoot;

		public Transform avatarRoot;

		public Transform graveRoot;

		private Character activeCharacter;

		private Character charaModel;

		private Character subCharaModel;

		private Dictionary<Character.SubAvatarChange, List<int>> conditionDic;

		private bool usePreCharaChangeMotion;

		private float changeDelay;

		private BgAvatarChangeEffect changeEffect;

		public BgUnit otherUnit;

		private Action objectTapCallback;

		public int BgNo => 0;

		public int AvatarNo
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int SubAvatarNo
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public AvatarStandType StandType
		{
			[CompilerGenerated]
			get
			{
				return default(AvatarStandType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int StandNo
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public BgGrave.GraveType GraveType => default(BgGrave.GraveType);

		public int GraveNo => 0;

		public BgUnit(Side side)
		{
		}

		public void AssignSetting(int matNo, string matSeLabel, int avatarNo, int subAvatarNo, AvatarModelSetting modelSetting, AvatarStandType standType, int standNo, BgGrave.GraveType graveType, int graveNo)
		{
		}

		public void SetAvatarNo(int avatarNo, string avatarResPath, int subAvatarNo = 0, string subAvatarResPath = "", string changeEffectPath = "")
		{
		}

		public void SetBgNo(int no, string seLabel)
		{
		}

		public void SetAvatarStandTypeAndNo(AvatarStandType type, int no)
		{
		}

		public void SetGraveTypeAndNo(BgGrave.GraveType type, int no)
		{
		}

		public string GetGraveTypeInital()
		{
			return null;
		}

		public void SetObjectTapCallback(Action callback)
		{
		}

		public void Load(Action onLoad)
		{
		}

		private void load(BgResourceIdx idx, Action onLoad)
		{
		}

		public void Initialize(Transform root, AvatarModelSetting setting)
		{
		}

		public void InitializeMat(Transform root)
		{
		}

		public void InitializeGrave()
		{
		}

		public void InitializeOtherSideEffectManager()
		{
		}

		public void InitializeAvatar(AvatarModelSetting setting)
		{
		}

		private void CharaModelInit(AvatarModelSetting setting)
		{
		}

		private void CharaModelDestroy()
		{
		}

		public void InitializeCharaModelSelector()
		{
		}

		public void Terminate()
		{
		}

		public void PlayBgStartAnimation()
		{
		}

		public void PlayCharaEntryAnimation()
		{
		}

		public void PlayFinishAnimation()
		{
		}

		public void PlayWinAnimation()
		{
		}

		public void PlayLoseAnimation()
		{
		}

		public void PlayEndAnimation(Engine.ResultType resultType)
		{
		}

		public void PlayTurnChangeAnimation()
		{
		}

		public void PlayDamageAnimation(Engine.DamageType type, int lp)
		{
		}

		public void PlayAttackAnimation()
		{
		}

		public void PlayAvatarChangeAnimation(Character.SubAvatarChange condition, bool flg, Action callback = null)
		{
		}

		private IEnumerator PlayAvatarChangeAnimationInner(Character.SubAvatarChange condition, Action callback = null)
		{
			return null;
		}

		public bool CheckSubAvatarCondition(Character.SubAvatarChange condition)
		{
			return false;
		}

		public bool CheckSubAvatarConditionParam(Character.SubAvatarChange condition, int target)
		{
			return false;
		}

		public Character GetActiveCharacter()
		{
			return null;
		}

		public bool IsSubAvatar()
		{
			return false;
		}

		public void MateEnable(bool flg)
		{
		}

		public void PlayMatTapAnimation()
		{
		}

		public bool IsMatTapPlaying()
		{
			return false;
		}

		public void OnObjectTapCallback()
		{
		}

		public void CheckDamagePhase(int lp, BgEffectManagerInner.CheckDamageCallback cb = null)
		{
		}

		public void CheckDamagePhaseForAudienceReplay(int lp)
		{
		}

		public void PlayEffect(BgEffectSettingInner.AnimationLabelDefine label)
		{
		}

		public void SetEnableTapEffect(BgEffectSettingInner.AnimationLabelDefine label, bool flg)
		{
		}

		public void SetEnableLoopEffect(BgEffectSettingInner.AnimationLabelDefine label, bool flg)
		{
		}

		public void PlayAnimatorTrigger(BgEffectSettingInner.TriggerLabelDefine label, string seLabel = "")
		{
		}

		public string GetMatSeLabel(BgPhase phase)
		{
			return null;
		}

		public string GetMatTapSeLabel()
		{
			return null;
		}

		public static void PlayStartAnimationForPreviewParts(GameObject obj)
		{
		}
	}
}
