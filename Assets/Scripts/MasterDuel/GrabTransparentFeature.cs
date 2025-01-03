using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class GrabTransparentFeature : ScriptableRendererFeature
{
	private class CustomRenderPass : ScriptableRenderPass
	{
		private int m_cameraTransparentTextureID;

		private int m_tmpTextureID;

		private string grabTransparentTag;

		private string commandBufferName;

		private RenderTargetIdentifier m_renderTarget;

		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		public void SetRenderTarget(RenderTargetIdentifier target)
		{
		}
	}

	private CustomRenderPass m_ScriptablePass;

	public override void Create()
	{
	}

	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
	}
}
