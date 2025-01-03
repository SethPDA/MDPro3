using System.Collections.Generic;

namespace UnityEngine.UI
{
	public class TextVertexGradation : BaseMeshEffect
	{
		public enum Direction
		{
			UpToBottom = 0,
			BottomToUp = 1,
			LeftToRight = 2,
			RightToLeft = 3
		}

		[SerializeField]
		public Color color;

		[SerializeField]
		public Direction direction;

		private const int VERTLEN = 6;

		private int[] gradBit;

		public void ModifyVertices(List<UIVertex> verts)
		{
		}

		public override void ModifyMesh(VertexHelper vh)
		{
		}
	}
}
