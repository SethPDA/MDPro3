using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using YgomGame.Card;
using YgomSystem.UI;

namespace YgomGame.Duel
{
	public class CardPlane : MonoBehaviour
	{
		private enum Step
		{
			Idle = 0,
			FlipTurn = 1
		}

		public enum IdlingType
		{
			Default = 0,
			HandSelecting = 1,
			HandDeciding = 2,
			FieldSelecting = 3,
			FieldDeciding = 4
		}

		public enum BrokenType
		{
			Break = 0,
			Explosion = 1
		}

		public enum MoveTrailType
		{
			None = 0,
			Normal = 1,
			Break = 2,
			Fusion = 3,
			Attack = 4,
			Exclude = 5,
			BreakExclude = 6,
			Release = 7,
			ReleaseExclude = 8,
			XyzMaterial = 9
		}

		private Step step;

		private float time;

		private Vector3 fromPosition;

		private Vector3 toPosition;

		private Quaternion fromRotationModel;

		private Quaternion toRotationModel;

		private Quaternion fromRotationTurn;

		private Quaternion toRotationTurn;

		private Action onFinished;

		private SimpleEffect highlightEff;

		private int highlightEffectOrder;

		private int highlightEffectOrderOffset;

		private SimpleEffect moveTrail;

		private Transform pivot;

		private DuelEffectPool.Type auraEffType;

		private Vector3 currentPivotPosition;

		private Quaternion currentPivotRotation;

		private bool insight;

		private IdlingType idlingType;

		private SharedDefinition.Location location;

		private BezierMotionSetting flipMotion;

		private BezierMotionSetting _flipMotionCard;

		private BezierMotionSetting _flipMotionPlateMonster;

		private BezierMotionSetting _flipMotionPlateMagic;

		private BezierMotionSetting _flipMotionDeckCard;

		private Tween[] tweens;

		private TweenPosition tweenShakePosition;

		private TweenRotation tweenShakeRotation;

		private TweenPositionTo tweenAttackReadyStart;

		private TweenPosition tweenAttackReadyIdle;

		private TweenPositionTo tweenAttackReadyFinish;

		private const string tweenLabelIdlingDefault = "default";

		private const string tweenLabelIdlingNearHandSelecting = "near_hand_selecting";

		private const string tweenLabelIdlingNearHandDeciding = "near_hand_deciding";

		private const string tweenLabelIdlingFarHandSelecting = "far_hand_selecting";

		private const string tweenLabelIdlingFarHandDeciding = "far_hand_deciding";

		private const string tweenLabelIdlingFieldSelecting = "field_selecting";

		private const string tweenLabelIdlingFieldDeciding = "field_deciding";

		private const string tweenLabelHandAppealEffect = "hand_appeal";

		public Transform offset
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

		public Transform turn
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

		public bool useFloatingPivot
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool floatingPivotPosition
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool floatingPivotRotation
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private BezierMotionSetting flipMotionCard => null;

		private BezierMotionSetting flipMotionPlateMonster => null;

		private BezierMotionSetting flipMotionPlateMagic => null;

		private BezierMotionSetting flipMotionDeckCard => null;

		public bool isTerminated => false;

		public CardRoot cardRoot
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

		public CardModel cardModel
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

		public bool showing
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

		public CardRoot.ModelType modelType => default(CardRoot.ModelType);

		public bool isLoaded => false;

		public static CardPlane Create(CardRoot cardRoot, GameObject go)
		{
			return null;
		}

		private void Initialize()
		{
		}

		public void Terminate()
		{
		}

		public void FlipTurn(bool isFace, bool isAttack, bool immediate, bool deckFlip, Action onFinished)
		{
		}

		public void CrearContents()
		{
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}

		public void ChangeModel(CardRoot.ModelType modelType)
		{
		}

		private void SetDispModelCard(bool disp)
		{
		}

		public void SetCardTextures(int cardId, int sleeveId, int uniqueId, int styleId, Action onLoaded = null)
		{
		}

		public void ReloadTexture(int cardId, int uniqueId, Action onLoaded = null)
		{
		}

		public void ReqHighlight(bool enable, SharedDefinition.ActivateAura type, int order = 0)
		{
		}

		public void SetHighlightEffectOrderOffset(int offset)
		{
		}

		public static DuelEffectPool.Type TrailTypeToEffectType(MoveTrailType trailType)
		{
			return default(DuelEffectPool.Type);
		}

		public void ReqMoveEffect(DuelEffectPool.Type eff_type, bool perisitent_vision = false)
		{
		}

		public void ReqStopMoveEffect()
		{
		}

		public void ReqAppealEffect(Action on_finished)
		{
		}

		public static (bool, DuelEffectPool.Type, string, string) GetBrokenEffectInfo(BrokenType brokenType)
		{
			return default((bool, DuelEffectPool.Type, string, string));
		}

		private void Update()
		{
		}

		private void SetupBackInsight(bool force = false)
		{
		}

		private void IdleStep()
		{
		}

		private void FlipTurnStep()
		{
		}

		private void UpdateTransition(float clampedTime)
		{
		}

		public void SetIdlingType(IdlingType idling_type, SharedDefinition.Location location)
		{
		}

		public void PlayTween(string label, bool stop_all = true)
		{
		}

		private void UpdatePivot(bool reset = false)
		{
		}

		public void ResetPivotPosition()
		{
		}

		public void SetCastShadow(bool isOn)
		{
		}

		public void Shake(Vector3 groundZero)
		{
		}

		public void StopShake()
		{
		}

		public void StartAttackReady()
		{
		}

		public void FinishAttackReady()
		{
		}

		public void StopTweens()
		{
		}

		public void ResetPosition()
		{
		}
	}
}
