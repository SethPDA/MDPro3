using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame.Duel
{
	public class CardRoot : MonoBehaviour, ICardStatusIconAnchor
	{
		public enum State
		{
			Invalid = 0,
			Suspend = 1,
			Ready = 2,
			Active = 3
		}

		public enum ModelType
		{
			StoneMonster = 1,
			StoneMagic = 4,
			OcgCard = 8,
			Soul = 0x10,
			SummonMaterial = 0x20
		}

		private enum Step
		{
			Idle = 0,
			Move = 1,
			Summon = 2
		}

		private Step step;

		private ElementObjectManager eoManager;

		private Queue<CardEffectBase> effectQueue;

		private CardEffectBase currentEffect;

		private bool attackReady;

		public bool validVal;

		public int position;

		private bool m_AtkBuffFlag;

		private bool m_AtkDebuffFlag;

		private bool m_DefBuffFlag;

		private bool m_DefDebuffFlag;

		private int m_Atk;

		private int m_Def;

		private int m_Level;

		private int m_Rank;

		private int m_Scale;

		private int m_CardAttr;

		public int m_CardType;

		public SharedDefinition.SummonMaterialType currentSummonMaterialType
		{
			[CompilerGenerated]
			get
			{
				return default(SharedDefinition.SummonMaterialType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public SharedDefinition.SummonMaterialType preparedSummonMaterialEffectType
		{
			[CompilerGenerated]
			get
			{
				return default(SharedDefinition.SummonMaterialType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Dictionary<string, SimpleEffect> holdEffects
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isTerminated => false;

		public bool isInMonsterZone => false;

		public bool isInMagicZoon => false;

		public bool isLoaded => false;

		public CardInstancePool cardPool
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

		public CardLocator cardLocator
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public CardPlane cardPlane
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

		public CardStatus cardStatus
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

		public State state
		{
			[CompilerGenerated]
			get
			{
				return default(State);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Transform cardPostureTransform => null;

		public bool manualUpdateSRT
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

		public GameObject effectAnchor => null;

		public Quaternion localRot => default(Quaternion);

		public Vector3 centerOfs => default(Vector3);

		public Vector3 surfaceOffset => default(Vector3);

		public Vector3 affectIconOffset => default(Vector3);

		public Vector3 atkDefOfs => default(Vector3);

		public Vector3 levelOfs => default(Vector3);

		public Vector3 attrOfs => default(Vector3);

		public Vector3 typeOfs => default(Vector3);

		public Vector3 counterOfs => default(Vector3);

		public Vector3 turnsOfs => default(Vector3);

		public int team
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

		public int index
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int cardId
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public int sleeveId
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public bool isFace
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

		public bool isAttack
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

		public int uniqueId
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

		public int atk
		{
			get
			{
				return 0;
			}
			private set
			{
			}
		}

		public int def
		{
			get
			{
				return 0;
			}
			private set
			{
			}
		}

		public int orgAtk
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

		public int orgDef
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

		public int level
		{
			get
			{
				return 0;
			}
			private set
			{
			}
		}

		public int rank
		{
			get
			{
				return 0;
			}
			private set
			{
			}
		}

		public int scale
		{
			get
			{
				return 0;
			}
			private set
			{
			}
		}

		public int orgScale
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

		public int orgLevel
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

		public int orgRank
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

		public int cardAttr
		{
			get
			{
				return 0;
			}
			private set
			{
			}
		}

		public bool cardAttrChanged
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

		public int cardType
		{
			get
			{
				return 0;
			}
			private set
			{
			}
		}

		public bool cardTypeChanged
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

		public int validCounter
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

		public int validCounterCount
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

		public List<Engine.CounterType> validCounters
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

		public List<int> validCountersCount
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

		public int elapsedTurns
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

		public bool cardDisabled
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

		public int linkNum
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

		public int orgLinkNum
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

		public static CardRoot Create(CardInstancePool cardPool, GameObject go)
		{
			return null;
		}

		public static bool IsNeedToCallRegister(CardLocator from, CardLocator to)
		{
			return false;
		}

		public static ModelType CheckModeByPosition(int position)
		{
			return default(ModelType);
		}

		private void Initialize()
		{
		}

		public void Terminate()
		{
		}

		public void SetCard(int cardId, int sleeveId, int uniqueId, Action onLoaded = null)
		{
		}

		public void SetCard(int cardId, int sleeveId, int uniqueId, int styleId, Action onLoaded = null)
		{
		}

		public void ReloadTexture(Action onLoaded = null)
		{
		}

		private void UpdateBasicVal()
		{
		}

		private void UpdateValidCounter()
		{
		}

		private void UpdateStatusIcon()
		{
		}

		public void TransitionToActive(bool showModel)
		{
		}

		public void TransitionToReady()
		{
		}

		public void TransitionToSuspend()
		{
		}

		public void Placement(CardLocator cardLocator, bool isFace, bool isAttack, bool show)
		{
		}

		public void ReqMoveFlipTurnEffect(CardLocator from, CardLocator to, bool isFace, bool isAttack, bool immediate, CardRootTransition transition, Action onStarted, Action onFinished)
		{
		}

		public void ReqFlipTurn(bool isFace, bool isAttack, bool immediate, Action onStarted, Action onFinished)
		{
		}

		public void StartMove()
		{
		}

		public void ReqMoveEffect(CardPlane.MoveTrailType type)
		{
		}

		public void ReqMoveEffect(DuelEffectPool.Type eff_type, bool persitent_vision = false)
		{
		}

		public void ReqStopMoveEffect()
		{
		}

		public void ReqPlaySE(string label, bool is3D)
		{
		}

		public void ReqStopSE(string label)
		{
		}

		public void ReqDisplay(bool disp)
		{
		}

		public void ReqHighlight(bool enable, SharedDefinition.ActivateAura type, int order = 0)
		{
		}

		public void ReqChangeModelType(ModelType modelType)
		{
		}

		public void ModelChange(ModelType type)
		{
		}

		public bool IsModelShowing()
		{
			return false;
		}

		public void ReqAppealEffect(Action on_finished)
		{
		}

		public void ReqCrackEffect(bool enable)
		{
		}

		public void ReqBrokenEffect(CardPlane.BrokenType brokenType, Quaternion rotation)
		{
		}

		public void ReqCastShadow(bool isOn)
		{
		}

		public void ReqZoneEffect(int player, int position, bool getOut, bool isFace, ModelType modelType)
		{
		}

		public void StartSummonMaterialTargetEffect(SharedDefinition.SummonMaterialType material_type)
		{
		}

		public void EndSacrificeTargetEffect()
		{
		}

		public void PrepareSummonMaterialEffect(SharedDefinition.SummonMaterialType type)
		{
		}

		public void ReqPreparedSummonMaterialEffect()
		{
		}

		public void ReqSummonMaterialEffect(SharedDefinition.SummonMaterialType type)
		{
		}

		public void ReqOneShotEffect(DuelEffectPool.Type type, CardEffectOneShotEffect.Mode mode, bool waitEffect, Quaternion rotation)
		{
		}

		private void ReqPlayHoldEffect(string holdEffectLabel, DuelEffectPool.Type type, CardEffectHoldEffect.Mode mode)
		{
		}

		private void ReqStopHoldEffect(string holdEffectLabel, bool immediate)
		{
		}

		public void ReqDisappear(Action onFinished)
		{
		}

		public void ReqCallback(Action callback, float delay = 0f)
		{
		}

		public void ReqWait(Func<bool> waitFunc)
		{
		}

		public void ReqAppearEffect(bool isToken, bool waitEffect, Action onFinished)
		{
		}

		public void Disapper()
		{
		}

		public void UpdateState()
		{
		}

		public void ShowPlane()
		{
		}

		public void HidePlane()
		{
		}

		public void ResetStatusValue()
		{
		}

		public void OnReturnInstance()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		private void IdleStep()
		{
		}

		private void UpdateCardPicture()
		{
		}

		public void UpdateSRT(bool force = false)
		{
		}

		private void ValidateFlipTurn()
		{
		}

		public T GetElement<T>(string label) where T : UnityEngine.Object
		{
			return null;
		}

		public void AddEffect(CardEffectBase effect)
		{
		}

		public bool IsEffectFinished()
		{
			return false;
		}

		public bool IsTargetEffectPlaying(Type type)
		{
			return false;
		}

		public bool IsZoneEffectPlaying(ZoneCard.Zone zone, ZoneCard.Mode mode)
		{
			return false;
		}

		public bool IsMoveEffectRequested()
		{
			return false;
		}

		public void UpdateEffect()
		{
		}

		private void ClearAllEffect()
		{
		}

		public void SetPlace(int team, int position, int index)
		{
		}

		private void BuffEffect()
		{
		}

		private void DebuffEffect()
		{
		}

		private void ChangeEffect()
		{
		}

		public void EffectReset()
		{
		}

		public void StartAttackReady()
		{
		}

		public void FinishAttackReady()
		{
		}
	}
}
