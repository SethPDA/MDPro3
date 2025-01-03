using UnityEngine;

namespace YgomGame.Duel
{
	public class FarHandCardPlace : HandCardPlace
	{
		private Vector3 _locatorOffsetTargetDeciding;

		private Vector3 _locatorOffsetTargetSelecting;

		protected override int selectedIndex => 0;

		protected override int decidedIndex => 0;

		public override int handCardNum => 0;

		protected override HandCardManager.ViewSortMode sortMode => default(HandCardManager.ViewSortMode);

		protected override Vector3 locatorOffsetTargetDeciding => default(Vector3);

		protected override Vector3 locatorOffsetTargetSelecting => default(Vector3);

		public override bool isAllOpen => false;

		public FarHandCardPlace(DuelFieldBase duelField, int team, int position)
			: base(null, 0, 0)
		{
		}

		protected override void SelectNextItem(int index)
		{
		}

		protected override void SelectPrevItem(int index)
		{
		}

		protected override void OnRegister(CardRoot cardRoot, int index, bool withEffect)
		{
		}

		protected override void HighlightImpl(int index, SharedDefinition.ActivateAura auraType)
		{
		}

		public override void UpdateCenterPosition()
		{
		}

		protected override void SetupCardLocator(CardLocator cardLocator)
		{
		}

		public override void GetPosture(int index, out Vector3 position, out Quaternion rotation, out float depth, int card_num = -1, bool originPosition = false)
		{
			position = default(Vector3);
			rotation = default(Quaternion);
			depth = default(float);
		}

		public override int GetViewIndex(int index)
		{
			return 0;
		}

		public override int GetIndexByViewIndex(int viewIndex)
		{
			return 0;
		}

		public override int UniqueIdToIndex(int uniqueId)
		{
			return 0;
		}

		protected override void SetSortImpl(HandCardManager.ViewSortMode sort)
		{
		}

		protected override void InsertViewIndexImpl(int targetIndex, int InsertViewIndex)
		{
		}

		protected override void RefreshCardLocatorsImpl()
		{
		}

		public override void UpdateAllCardPosition()
		{
		}
	}
}
