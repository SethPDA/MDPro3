using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using YgomGame.Duel;

namespace YgomGame.Bg
{
	public class BgManager : MonoBehaviour
	{
		private enum Step
		{
			InitializingLoad = 0,
			InitializingLight = 1,
			InitializingSphere = 2,
			InitializingMyMat = 3,
			InitializingRivalMat = 4,
			InitializingMyGrave = 5,
			InitializingRivalGrave = 6,
			InitializingAvatar = 7,
			Idle = 8
		}

		public const string bgLightResPath = "Duel/BG/Light/GlobalFieldLight";

		public const string bgSphereResPath = "Duel/BG/CelestialSphere/CelestialSphere_{0}{1:000}/CelestialSphere_{0}{1:000}";

		private Step step;

		private int[] matId;

		private int[] standId;

		private int[] graveId;

		private int[] avatarId;

		private int sphereId;

		private bool useClientworkId;

		private bool bgResLoaded;

		private GameObject bgLightRes;

		private GameObject bgLightObj;

		private bool bgLightLoaded;

		private GameObject bgSphereRes;

		private GameObject bgSphereObj;

		private bool bgSphereLoaded;

		private bool isErrModelSrc;

		private BgUnit[] bgUnits;

		private BgMatModelSetting matModelSetting;

		private BgGraveModelSetting graveModelSetting;

		private BgStandModelSetting standModelSetting;

		private AvatarModelSetting characterModelSetting;

		private bool useSphere => false;

		public BgMatModelSetting MatModelSetting => null;

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

		public bool bgCameraEnabled => false;

		public BgUnit GetBgUnit(BgUnit.Side side)
		{
			return null;
		}

		public BgUnit GetBgUnit(bool isMyself)
		{
			return null;
		}

		public static BgManager Create(DuelGameObjectManager goManager, GameObject root, string name, bool useCwId = true)
		{
			return null;
		}

		public static BgManager Create(Transform root, string name, int sphereId, params int[] ids)
		{
			return null;
		}

		private static BgManager Create(Transform root, string name, bool useCwId, int sphereId = 1)
		{
			return null;
		}

		public void Initialize()
		{
		}

		public void InitalizeLoad()
		{
		}

		private IEnumerator LoadAudioClipCoroutine()
		{
			return null;
		}

		public void PlayCameraStartAnimation()
		{
		}

		public void PlayPlayCameraStartAnimationTimer(GameObject timer = null)
		{
		}

		public void PlayPlayCameraStartAnimationPhaseSelect(GameObject phaseSelect = null)
		{
		}

		public void PlayEntryAnimation()
		{
		}

		public void PlayDamageAnimation(Engine.DamageType type, int team, int damage)
		{
		}

		public void PlayFinishAnimation(int team)
		{
		}

		public void PlayWinAnimation(int team)
		{
		}

		public void PlayLoseAnimation(int team)
		{
		}

		public void PlayEndAnimation(Engine.ResultType resultType)
		{
		}

		public void PlayTurnChangeAnimation()
		{
		}

		public void PlayEffect(int side, BgEffectSettingInner.AnimationLabelDefine label)
		{
		}

		public void ObjectTapCallback()
		{
		}

		public void Terminate()
		{
		}

		public void Inactivate()
		{
		}

		private void Update()
		{
		}

		private void InitializingLightStep()
		{
		}

		private void InitializingSphereStep()
		{
		}

		private void InitializingMyMatStep()
		{
		}

		private void InitializingRivalMatStep()
		{
		}

		private void InitializingMyGraveStep()
		{
		}

		private void InitializingRivalGraveStep()
		{
		}

		private void InitializingAvatarStep()
		{
		}

		private void IdleStep()
		{
		}

		public void InitializeSelector()
		{
		}

		public void SetBgGraveHighlight(bool flg)
		{
		}
	}
}
