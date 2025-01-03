using TMPro;
using UnityEngine;

namespace YgomSystem
{
	public static class TMP_TextInfoExtended
	{
		public enum VERTEXINDEX
		{
			LEFT_BOTTOM = 0,
			LEFT_TOP = 1,
			RIGHT_TOP = 2,
			RIGHT_BOTTOM = 3
		}

		public static Vector3 GetMeshVertex(this TMP_TextInfo tmpinfo, int charaindex, VERTEXINDEX vertindex)
		{
			return default(Vector3);
		}

		public static void SetMeshVertex(this TMP_TextInfo tmpinfo, int charaindex, VERTEXINDEX vertindex, Vector3 vertex)
		{
		}

		public static float GetMeshHeight(this TMP_TextInfo tmpinfo, int charaindex)
		{
			return 0f;
		}
	}
}
