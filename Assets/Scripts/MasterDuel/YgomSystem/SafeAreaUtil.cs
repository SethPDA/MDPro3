using UnityEngine;

namespace YgomSystem
{
	public static class SafeAreaUtil
	{
		private static bool setup;

		private static Rect _safeArea;

		private static Vector2 _anchorMin;

		private static Vector2 _anchorMax;

		public static Rect safeArea => default(Rect);

		public static Vector2 anchorMin => default(Vector2);

		public static Vector2 anchorMax => default(Vector2);

		public static void Setup(bool force = false)
		{
		}

		public static Rect GetSafeArea()
		{
			return default(Rect);
		}
	}
}
