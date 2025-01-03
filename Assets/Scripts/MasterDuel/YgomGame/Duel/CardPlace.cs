using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomGame.Duel
{
	public abstract class CardPlace
	{
		private enum Step
		{
			Idle = 0,
			InitLoadCard = 1,
			WaitLoadCard = 2
		}

		private enum CommandPower
		{
			None = 0,
			Low = 1,
			Middle = 2,
			High = 3
		}

		public DuelFieldBase duelField;

		public int team;

		public int position;

		protected Dictionary<int, CardLocator> cardLocators;

		private Step step;

		private SimpleEffect affectTargetEff;

		private SimpleEffect affectRelativeEff;

		protected int currentLoadIdx;

		protected int numLoadCards;

		private int numIncomings;

		private int numOutgoings;

		private Action onFinishedCardMove;

		private Action onFinishedPrepare;

		private Dictionary<Engine.CommandType, CommandPower> commandPowerList;

		protected CardLocator typicalLocator;

		public bool incoming => false;

		public bool outgoing => false;

		public bool turning
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

		public bool cardMoving => false;

		public int incomingFromPosition
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

		protected virtual int loadStartIdx => 0;

		protected virtual int loadIndexIncValue => 0;

		protected virtual bool loadIsOver => false;

		public bool isPrepared
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public bool isReady => false;

		public virtual bool isStatusVisible => false;

		public virtual void OnUpdate()
		{
		}

		public virtual bool UpdateInitialize()
		{
			return false;
		}

		public virtual bool UpdateTerminate()
		{
			return false;
		}

		public virtual CardLocator GetCardLocator(int index, bool create, bool insert)
		{
			return null;
		}

		protected void AddCardLocator(int index, CardLocator cardLocator)
		{
		}

		protected virtual void UpdateLocators()
		{
		}

		protected virtual void SetupCardLocator(CardLocator cardLocator)
		{
		}

		protected virtual CardRoot GetCardRoot(int index)
		{
			return null;
		}

		protected virtual CardLocator OnEnter(CardRoot cardRoot, int index, bool reqUpdateIndices)
		{
			return null;
		}

		protected virtual bool OnLeave(CardRoot cardRoot, int index, bool reqUpdateIndices)
		{
			return false;
		}

		protected virtual void OnRegister(CardRoot cardRoot, int index, bool withEffect)
		{
		}

		protected virtual void OnUnregister(CardRoot cardRoot, int index)
		{
		}

		public virtual Vector3 GetScreenPos(int index, Vector2 ofsRate)
		{
			return default(Vector3);
		}

		public CardPlace(DuelFieldBase duelField, int team, int position)
		{
		}

		public virtual void Terminate()
		{
		}

		public CardLocator Enter(CardRoot cardRoot, int index, bool reqUpdateIndices)
		{
			return null;
		}

		public void Leave(CardRoot cardRoot, int index, bool reqUpdateIndices)
		{
		}

		public void Register(CardRoot cardRoot, int index, bool withEffect)
		{
		}

		public void Unregister(CardRoot cardRoot, int index)
		{
		}

		protected void AddOnFinishedCardMove(Action onFinished)
		{
		}

		public void Update()
		{
		}

		private void InitLoadCardStep()
		{
		}

		public void PrepareToDuel()
		{
		}

		protected virtual void OnPrepareToDuel(bool startAtZero, Action onFinished)
		{
		}

		public void ShowUp(bool playEffect, Action onFinished)
		{
		}

		protected virtual void OnShowUp(bool playEffect, Action onFinished)
		{
		}

		public virtual Vector3 GetTypicalPos()
		{
			return default(Vector3);
		}

		public virtual Quaternion GetTypicalRot()
		{
			return default(Quaternion);
		}

		public virtual Vector3 GetTypicalScale()
		{
			return default(Vector3);
		}

		public void Shuffle(Action onFinished)
		{
		}

		protected virtual void ShuffleImpl(Action onFinished)
		{
		}

		public virtual void HighlightIfAvailable(bool available, uint cmdBit, Action onFinished)
		{
		}

		public void ReqHighlight(bool available, uint cmdBit, Action onFinished)
		{
		}

		protected virtual void ReqHighlightImpl(bool available, uint cmdBit, Action onFinished)
		{
		}

		protected SharedDefinition.ActivateAura GetActivateAura(int index, uint activeCommandBit)
		{
			return default(SharedDefinition.ActivateAura);
		}

		public void FlipTurn(int index, bool isFace, bool isAttack, bool immediate, Action onFinished)
		{
		}

		protected virtual void FlipTurnImpl(int index, bool isFace, bool isAttack, bool immediate, Action onFinished)
		{
		}

		protected virtual void FlipTurnStartImpl(CardRoot cardRoot, bool isFace)
		{
		}

		public void ReqDecideEffect(int index, Action onFinished)
		{
		}

		protected virtual void ReqDecideEffectImpl(int index, Action onFinished)
		{
		}

		public void EndSacrificeTargetEffect(int index, Action onFinished)
		{
		}

		protected virtual void EndSacrificeTargetEffectImpl(int index, Action onFinished)
		{
		}

		public virtual void StartAffectRelativeEffect(Engine.AffectType affectType, Action onFinished)
		{
		}

		protected virtual void StartAffectRelativeEffectImpl(Engine.AffectType affectType, Action onFinished)
		{
		}

		public virtual void EndAffectEffect(Action onFinished)
		{
		}

		public virtual void EndAffectEffectImpl(Action onFinished)
		{
		}

		public void UpdateState(Action onFinished)
		{
		}

		protected virtual void UpdateStateImpl(Action onFinished)
		{
		}

		public virtual void OnSelected()
		{
		}

		public virtual void OnDeselected()
		{
		}

		public virtual int GetIndexByViewIndex(int viewIndex)
		{
			return 0;
		}

		public virtual int GetViewIndex(int index)
		{
			return 0;
		}
	}
}
