using UnityEngine;
using UnityEngine.UI;
using YgomSystem.UI;

namespace YgomSystem.Extension.UGUI.ScrollRectExtension
{
	public static class ScrollRectExtension
	{
		public enum InputMode
		{
			DirectionalKey = 1,
			AnalogMain = 2,
			AnalogSub = 4
		}

		public static void SetGamePadInputScroll(this ScrollRect scrollRect, InputMode inputMode = (InputMode)7)
		{
		}

		public static void ScrollMovement(this ScrollRect scrollRect, PadInputDirection direction)
		{
		}

		public static void ScrollMovementRight(this ScrollRect scrollRect)
		{
		}

		public static void ScrollMovementLeft(this ScrollRect scrollRect)
		{
		}

		public static void ScrollMovementUp(this ScrollRect scrollRect)
		{
		}

		public static void ScrollMovementDown(this ScrollRect scrollRect)
		{
		}

		public static void ScrollMovement(this ScrollRect scrollRect, Vector2 dir)
		{
		}

		public static Vector2 GetMovementAmount(this ScrollRect scrollRect, PadInputDirection direction)
		{
			return default(Vector2);
		}

		public static Vector2 GetMovementAmount(this ScrollRect scrollRect, Vector2 dir)
		{
			return default(Vector2);
		}

		public static void SetOnSelectedItemInnerFocus(this ExtendedScrollRect scrollRect, SelectionItem selectionItem)
		{
		}

		private static void OnSelectedItemInnerFocus(this ExtendedScrollRect scrollRect, SelectionItem selectionItem)
		{
		}

		public static void SetOnSelectedItemEdgeFocus(this ExtendedScrollRect scrollRect, SelectionItem selectionItem, PadInputDirection direction)
		{
		}

		private static void OnSelectedItemEdgeFocus(this ExtendedScrollRect scrollRect, PadInputDirection direction)
		{
		}
	}
}
