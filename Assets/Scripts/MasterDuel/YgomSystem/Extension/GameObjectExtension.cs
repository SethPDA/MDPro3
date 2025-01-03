using UnityEngine;
using YgomSystem.UI;

namespace YgomSystem.Extension
{
	public static class GameObjectExtension
	{
		public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
		{
			return null;
		}

		public static T AddOrReplaceComponent<T>(this GameObject gameObject) where T : Component
		{
			return null;
		}

		public static void RemoveComponent<T>(this GameObject gameObject) where T : Component
		{
		}

		public static void SetSurfaceActive(this GameObject gameObject, bool value, params Selector[] selectors)
		{
		}

		public static bool GetSurfaceActive(this GameObject gameObject)
		{
			return false;
		}
	}
}
