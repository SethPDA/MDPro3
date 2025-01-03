using UnityEngine;

namespace YgomSystem.Extension
{
	public static class RectTransformExtension
	{
		private static readonly Vector3[] s_Corners;

		public static void ToStretch(this RectTransform rectTransform)
		{
		}

		public static void ToNeutral(this RectTransform rectTransform)
		{
		}

		public static void ToRight(this RectTransform rectTransform)
		{
		}

		public static void ToRightStretch(this RectTransform rectTransform)
		{
		}

		public static void CaptureTo(this RectTransform rectTransform, RectTransform target)
		{
		}

		public static Camera GetCamera(this RectTransform rectTransform)
		{
			return null;
		}

		public static RectTransform GetParentRect(this RectTransform rectTransform)
		{
			return null;
		}

		public static Vector3 GetScreenPosition(this RectTransform rectTransform)
		{
			return default(Vector3);
		}

		public static Vector3 ScreenToWorldPoint(this RectTransform rectTransform, Vector3 screenPos)
		{
			return default(Vector3);
		}

		public static bool IsContainRect(this RectTransform rectTransform, RectTransform checkRect)
		{
			return false;
		}

		public static bool IsContainRect(this RectTransform rectTransform, Canvas canvas, RectTransform checkRect)
		{
			return false;
		}

		public static bool IsInnerRect(this RectTransform rectTransform, RectTransform checkRect)
		{
			return false;
		}

		public static bool IsInnerRect(this RectTransform rectTransform, Canvas canvas, RectTransform checkRect)
		{
			return false;
		}

		public static Bounds CalculateRelativeRectTransformBounds(this RectTransform root, RectTransform child, bool nest = false)
		{
			return default(Bounds);
		}

		public static Vector2 GetSizeDeltaWithPlatformOverrider(this RectTransform rectTransform)
		{
			return default(Vector2);
		}

		public static void SetSizeDeltaWithPlatformOverrider(this RectTransform rectTransform, Vector2 sizeDelta)
		{
		}
	}
}
