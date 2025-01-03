using UnityEngine;

namespace YgomSystem.UI
{
	public class RectSelectionItem : SelectionItem
	{
		private Vector3[] rectWorldCorners;

		private Vector3[] boxWorldCorners;

		private Vector2[] viewPoints;

		public bool useWorldRectSetting;

		public Vector2 worldRectHalfSize;

		public Vector3 worldRectCenter;

		public Vector3 worldRectAngle;

		public override Vector2 viewCenterPosition => default(Vector2);

		public override Vector2 GetClosestPoint(Vector2 base_position, Vector2 direction, bool contains_check = true)
		{
			return default(Vector2);
		}

		protected virtual void SetupViewPoints()
		{
		}

		private Vector3 ElementScale(Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		public override bool IsContainsPoint(Vector2 view_position)
		{
			return false;
		}

		public override bool IsRectContains(Vector2 rect_point0, Vector2 rect_point1, Vector2 rect_point2, Vector2 rect_point3, bool containedComplete)
		{
			return false;
		}

		private void LateUpdate()
		{
		}

		public void SetupWorldRect(bool use, Vector2 half_size, Vector3 center, Vector3 angle)
		{
		}

		public Vector2[] CloneViewPoints()
		{
			return null;
		}
	}
}
