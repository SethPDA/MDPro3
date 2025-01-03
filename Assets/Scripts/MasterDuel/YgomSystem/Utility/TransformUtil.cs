using UnityEngine;

namespace YgomSystem.Utility
{
	public static class TransformUtil
	{
		public static (int, int) GetHierarchyDepth(Transform target, Transform root = null)
		{
			return default((int, int));
		}

		public static int GetHierarchyIndex(Transform target, Transform root)
		{
			return 0;
		}

		private static bool GetChildCount(Transform parent, Transform findTarget, ref int index)
		{
			return false;
		}

		public static string GetHierarchyPath(Transform target)
		{
			return null;
		}
	}
}
