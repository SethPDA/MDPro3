using System.Collections;
using System.Collections.Generic;

namespace UnityEngine.UI
{
	public class TextVertexLimitter : BaseMeshEffect
	{
		private struct TagInfo
		{
			public int Index;

			public int Length;
		}

		private const string SupportedTagRegexPattern = "<b>|</b>|<i>|</i>|<size=.*?>|</size>|<color=.*?>|</color>|<material=.*?>|</material>";

		[SerializeField]
		private bool useRichText;

		[SerializeField]
		public int startPos;

		[SerializeField]
		public int length;

		protected const int VERTLEN = 6;

		public override void ModifyMesh(VertexHelper vh)
		{
		}

		protected virtual void OnModifyMesh(VertexHelper vh, List<UIVertex> verts)
		{
		}

		private int RemoveRange(List<UIVertex> verts, int index, int count, List<TagInfo> tags)
		{
			return 0;
		}

		private bool CheckTag(int index, List<TagInfo> tags, ref int tagIdx)
		{
			return false;
		}

		private IEnumerator GetRegexMatchedTagCollection(string line, out int lineLengthWithoutTags)
		{
			lineLengthWithoutTags = default(int);
			return null;
		}
	}
}
