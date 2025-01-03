using UnityEngine;

namespace YgomSystem.UI
{
	[ExecuteInEditMode]
	public class BokehCamera : MonoBehaviour
	{
		public Shader shader;

		private Material material;

		private RenderTexture[] renderTexture;

		private void Start()
		{
		}

		public void BokeStart()
		{
		}

		public void BokeStop()
		{
		}

		private void OnRenderImage(RenderTexture src, RenderTexture dst)
		{
		}
	}
}
