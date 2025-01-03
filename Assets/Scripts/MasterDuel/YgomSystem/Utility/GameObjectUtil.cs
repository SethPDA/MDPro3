using UnityEngine;

namespace YgomSystem.Utility
{
	public static class GameObjectUtil
	{
		private static readonly string[] legacy_names;

		public static GameObject FindInChildren(GameObject parent, string name, bool includeInactive = false)
		{
			return null;
		}

		public static GameObject FindWithPathInChildren(GameObject root, string path, bool includeInactive = false)
		{
			return null;
		}

		private static GameObject FindWithPathInChildren(GameObject currentGo, string[] paths, int findIdx, bool includeInactive)
		{
			return null;
		}

		public static T FindInChildren<T>(GameObject parent, string name, bool includeInactive = false) where T : Component
		{
			return null;
		}

		public static T FindInParent<T>(GameObject go) where T : Component
		{
			return null;
		}

		public static bool IsParent(GameObject go, GameObject parent)
		{
			return false;
		}

		public static void SetX(this Transform transform, float x)
		{
		}

		public static void SetY(this Transform transform, float y)
		{
		}

		public static void SetZ(this Transform transform, float z)
		{
		}

		public static void SetXY(this Transform transform, Vector2 position)
		{
		}

		public static void SetXY(this Transform transform, float x, float y)
		{
		}

		public static void SetLocalX(this Transform transform, float x)
		{
		}

		public static void SetLocalY(this Transform transform, float y)
		{
		}

		public static void SetLocalZ(this Transform transform, float z)
		{
		}

		public static void SetLocalXY(this Transform transform, Vector2 position)
		{
		}

		public static void SetScaleX(this Transform transform, float x)
		{
		}

		public static void SetScaleY(this Transform transform, float y)
		{
		}

		public static void SetScaleZ(this Transform transform, float z)
		{
		}

		public static void SetLocalXY(this Transform transform, float x, float y)
		{
		}

		public static void SetAnchorX(this RectTransform rect, float x)
		{
		}

		public static void SetAnchorY(this RectTransform rect, float y)
		{
		}

		public static void SetAnchorZ(this RectTransform rect, float z)
		{
		}

		public static void SetActiveEx(this GameObject go, bool active)
		{
		}

		public static void DestroyMaterials(GameObject go, bool includeinactive = false)
		{
		}

		public static string GetReplacedLegacyShaderName(string name)
		{
			return null;
		}

		public static void SetLayer(GameObject target, int layer, bool recursive = false)
		{
		}
	}
}
