using System.Collections.Generic;

namespace UnityEngine.UI
{
	public class OutlineDouble : Shadow
	{
		public Vector2 offset;

		public Color effectColor2;

		public Vector2 effectDistance2;

		protected OutlineDouble()
		{
		}

		public override void ModifyMesh(VertexHelper vh)
		{
		}

		private int addOutlineVerts(List<UIVertex> verts, int start, Color color, Vector2 ofs, Vector2 dist)
		{
			return 0;
		}
	}
}
