using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI
{
	[ExecuteAlways]
	public class ModifyEdgeVertScale : BaseMeshEffect
	{
		[SerializeField]
		private Vector2 m_UpperLeft;

		[SerializeField]
		private Vector2 m_UpperRight;

		[SerializeField]
		private Vector2 m_LowerLeft;

		[SerializeField]
		private Vector2 m_LowerRight;

		private List<UIVertex> m_VertsCache;

		public override void ModifyMesh(VertexHelper vh)
		{
		}
	}
}
