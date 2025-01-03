using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomGame.Duel
{
	public class BasicCardPlace : CardPlace
	{
		private const float maxStacking = 3f;

		private bool showUnavailavleZoneEff;

		public GameObject anchor
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public override bool isStatusVisible => false;

		protected virtual void OnEnterImpl(CardRoot cardRoot, int index, bool reqUpdateIndices)
		{
		}

		protected virtual void OnLeaveImpl(CardRoot cardRoot, int index, bool reqUpdateIndices)
		{
		}

		protected virtual void OnRegisterImpl(CardRoot cardRoot, int index)
		{
		}

		protected virtual void OnUnregisterImpl(CardRoot cardRoot, int index)
		{
		}

		public BasicCardPlace(DuelFieldBase duelField, int team, int position, GameObject anchor)
			: base(null, 0, 0)
		{
		}

		public BasicCardPlace(BasicCardPlace src)
			: base(null, 0, 0)
		{
		}

		private void Init(DuelFieldBase duelField, int team, int position, GameObject anchor)
		{
		}

		public override bool UpdateTerminate()
		{
			return false;
		}

		protected override bool OnLeave(CardRoot cardRoot, int index, bool reqUpdateIndices)
		{
			return false;
		}

		protected override CardLocator OnEnter(CardRoot cardRoot, int index, bool reqUpdateIndices)
		{
			return null;
		}

		protected override void OnRegister(CardRoot cardRoot, int index, bool withEffect)
		{
		}

		protected override void OnUnregister(CardRoot cardRoot, int index)
		{
		}

		protected override void ReqDecideEffectImpl(int index, Action onFinished)
		{
		}

		protected override void EndSacrificeTargetEffectImpl(int index, Action onFinished)
		{
		}

		protected override void UpdateStateImpl(Action onFinished)
		{
		}

		public override Vector3 GetScreenPos(int index, Vector2 ofsRate)
		{
			return default(Vector3);
		}

		public void SwapTo(BasicCardPlace to, int toIndexOffset, CardRootTransition transition, Action onFinished)
		{
		}

		protected override void UpdateLocators()
		{
		}

		protected override void SetupCardLocator(CardLocator cardLocator)
		{
		}
	}
}
