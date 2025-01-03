using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using YgomSystem.UI;

namespace YgomGame.Duel
{
	public abstract class HandCardPlace : CardPlace
	{
		private enum ShuffleStep
		{
			Idle = 0,
			Shrink = 1,
			Expand = 2
		}

		private ShuffleStep shuffleStep;

		protected float shuffleTimer;

		protected Action onFinishedShuffle;

		protected float flabellateAngleBase;

		protected float flabellateAngle;

		protected float flabellateAngleLimit;

		protected float rate;

		protected float flabellateRadiusPerScreen;

		private float shuffleTimeShrink;

		private float shuffleTimeExpand;

		protected Vector3 centerViewport;

		protected float centerScale;

		protected float centerScaleSmall;

		protected float centerHeight;

		protected float selectingOffsetLerp;

		protected Dictionary<HandCardManager.DispMode, Vector3> centerPositions;

		protected int preSelectIndex;

		protected int preDecideIndex;

		private float _angleOffset;

		private Vector2 preScreenPoint;

		private bool dragAngleScroll;

		protected bool isBusy;

		protected List<(GameObject, SelectionButton)> selectionItems;

		protected GameObject handCardObj;

		private int createdHandCardCount;

		protected SharedDefinition.Location location;

		protected HandCardManager manager;

		private Selector selector;

		private bool showDetailStatus;

		private PlaceStatusLabel statusLabel;

		public abstract int handCardNum { get; }

		protected abstract int selectedIndex { get; }

		protected abstract int decidedIndex { get; }

		protected int selectedViewIndex => 0;

		protected int decidedViewIndex => 0;

		protected abstract Vector3 locatorOffsetTargetSelecting { get; }

		protected abstract Vector3 locatorOffsetTargetDeciding { get; }

		public abstract bool isAllOpen { get; }

		protected float angleOffset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		protected float angleOffsetOrg => 0f;

		protected float clampedAngleOffset => 0f;

		protected virtual HandCardManager.ViewSortMode sortMode
		{
			[CompilerGenerated]
			get
			{
				return default(HandCardManager.ViewSortMode);
			}
		}

		protected override int loadStartIdx => 0;

		protected override int loadIndexIncValue => 0;

		protected override bool loadIsOver => false;

		protected abstract void HighlightImpl(int index, SharedDefinition.ActivateAura auraType);

		public HandCardPlace(DuelFieldBase duelField, int team, int position)
			: base(null, 0, 0)
		{
		}

		protected void CreateHandCardObject(string obj_name)
		{
		}

		public override Vector3 GetScreenPos(int index, Vector2 ofsRate)
		{
			return default(Vector3);
		}

		public override void OnUpdate()
		{
		}

		private void IdleStep()
		{
		}

		public override CardLocator GetCardLocator(int index, bool create = true, bool insert = false)
		{
			return null;
		}

		private void SetupSelectionItem(SelectionButton item)
		{
		}

		public void SetupAngleOffset(int viewIndex)
		{
		}

		private int GetSelectionItemIndex(SelectionItem item)
		{
			return 0;
		}

		private int GetSelectionItemViewIndex(SelectionItem item)
		{
			return 0;
		}

		protected abstract void SelectNextItem(int index);

		protected abstract void SelectPrevItem(int index);

		protected void UpdateSelectionItem(GameObject actItemParent, SelectionItem actItem, CardLocator locator)
		{
		}

		private void UpdateLocatorOffset(CardLocator locator, bool immediate)
		{
		}

		private void UpdateLocatorOffsetAll(bool immediate)
		{
		}

		protected override CardLocator OnEnter(CardRoot cardRoot, int index, bool reqUpdateIndices)
		{
			return null;
		}

		protected override bool OnLeave(CardRoot cardRoot, int index, bool reqUpdateIndices)
		{
			return false;
		}

		private void ArrangementLocators()
		{
		}

		protected override void OnRegister(CardRoot cardRoot, int index, bool withEffect)
		{
		}

		protected override void OnUnregister(CardRoot cardRoot, int index)
		{
		}

		protected override void ShuffleImpl(Action onFinished)
		{
		}

		protected void UpdateShuffle()
		{
		}

		protected override void EndSacrificeTargetEffectImpl(int index, Action onFinished)
		{
		}

		protected override void ReqHighlightImpl(bool available, uint cmdBit, Action onFinished)
		{
		}

		protected override void ReqDecideEffectImpl(int index, Action onFinished)
		{
		}

		protected override void FlipTurnImpl(int index, bool isFace, bool isAttack, bool immediate, Action onFinished)
		{
		}

		public override Vector3 GetTypicalPos()
		{
			return default(Vector3);
		}

		public abstract int UniqueIdToIndex(int uniqueId);

		protected void SyncEngineHandCardIndex()
		{
		}

		protected void SyncHandCardIndex(int[] unique_ids)
		{
		}

		public abstract void GetPosture(int index, out Vector3 position, out Quaternion rotation, out float depth, int card_num = -1, bool originPosition = false);

		protected float GetFlabellateAngle(int viewIndex, bool origin, bool baseAngle, bool clamp180 = true)
		{
			return 0f;
		}

		protected float GetFlabellateAngle(int viewIndex, int handNum, bool origin, bool baseAngle, bool clamp180 = true)
		{
			return 0f;
		}

		public abstract void UpdateCenterPosition();

		protected override void UpdateLocators()
		{
		}

		protected void UpdateLocator(CardLocator actLocator, int index)
		{
		}

		protected override void SetupCardLocator(CardLocator cardLocator)
		{
		}

		private void SetCardFloatingMove(bool useFloatingPivot)
		{
		}

		private void ResetCardPivotPosition()
		{
		}

		public void SetSort(HandCardManager.ViewSortMode sort, bool select = true)
		{
		}

		protected abstract void SetSortImpl(HandCardManager.ViewSortMode sort);

		public void InsertViewIndex(int targetIndex, int insertViewIndex, bool select)
		{
		}

		protected abstract void InsertViewIndexImpl(int targetIndex, int InsertViewIndex);

		public void RefreshCardLocators(bool updateCardPosition)
		{
		}

		protected abstract void RefreshCardLocatorsImpl();

		public bool Select(int index, bool force = false)
		{
			return false;
		}

		public bool SelectByViewIndex(int viewIndex, bool force = false)
		{
			return false;
		}

		public void ShowStatusLabel(bool immediate, bool showDetail)
		{
		}

		public void HideStatusLabel(bool immediate, bool finishDetail = false)
		{
		}

		public abstract void UpdateAllCardPosition();
	}
}
