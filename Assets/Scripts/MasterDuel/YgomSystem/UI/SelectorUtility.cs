using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomSystem.UI
{
	public static class SelectorUtility
	{
		private static Vector2 directionUp;

		private static Vector2 directionRight;

		private static Vector2 directionDown;

		private static Vector2 directionLeft;

		public static bool IsRectContainsPoint(Vector2 rect_point0, Vector2 rect_point1, Vector2 rect_point2, Vector2 rect_point3, Vector2 check_point)
		{
			return false;
		}

		public static int GetSign(float v)
		{
			return 0;
		}

		public static SelectorManager.KeyType GamePadKeyTypeToKeyType(int gamepad_key_type)
		{
			return default(SelectorManager.KeyType);
		}

		public static (SelectionItem, float) GetClosestItem(Vector2 screenPoint, Vector2 direction, List<SelectionItem> targets, float angleDot, float minSqrDistance = -1f)
		{
			return default((SelectionItem, float));
		}

		public static bool InvokeAction(Action action)
		{
			return false;
		}

		public static bool InvokeAction<T1>(Action<T1> action, T1 arg1)
		{
			return false;
		}

		public static bool InvokeAction<T1, T2>(Action<T1, T2> action, T1 arg1, T2 arg2)
		{
			return false;
		}

		public static bool InvokeAction<T1, T2, T3>(Action<T1, T2, T3> action, T1 arg1, T2 arg2, T3 arg3)
		{
			return false;
		}

		public static Vector2 DirectionToVector2(PadInputDirection direction)
		{
			return default(Vector2);
		}
	}
}
