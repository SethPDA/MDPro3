using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI
{
	[ExecuteAlways]
	public class UGUIParticle : MaskableGraphic
	{
		private Camera m_RenderCameraCache;

		private ParticleSystemRenderer m_ParticleSystemRendererCache;

		private Mesh m_Mesh;

		private List<Vector3> m_Vertices;

		private List<Vector3> m_UVs;

		private List<int> m_Triangles;

		private List<Color32> m_Colors32;

		private Camera renderCamera => null;

		public ParticleSystemRenderer particleSystemRenderer => null;

		public override Texture mainTexture => null;

		public override Material material
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override void Start()
		{
		}

		private void Update()
		{
		}

		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		protected override void OnDidApplyAnimationProperties()
		{
		}
	}
}
