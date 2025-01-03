using UnityEngine;

namespace YgomSystem.UI
{
	public class SelectionButtonUntouchable : SelectionButton
	{
		public override Vector2 GetClosestPoint(Vector2 base_position, Vector2 direction, bool contains_check = true)
		{
			return default(Vector2);
		}

		public override bool IsContainsPoint(Vector2 view_position)
		{
			return false;
		}

		public override bool IsRectContains(Vector2 rect_point0, Vector2 rect_point1, Vector2 rect_point2, Vector2 rect_point3, bool containedComplete)
		{
			return false;
		}

		public static SelectionButtonUntouchable Create(GameObject target)
		{
			return null;
		}

		protected override void SetupViewPoints()
		{
		}
	}
}
