using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomSystem.CameraSystem
{
	public class CameraRenderController : MonoBehaviour
	{
		private CameraRenderTargetUI _renderTargetUI;

		[SerializeField]
		private int renderTextureWidth;

		public static CameraRenderController instance;

		public static RenderTexture mainCameraRenderTexture
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private CameraRenderTargetUI renderTargetUI => null;

		public float renderTextureScale => 0f;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void CreateRenderTexture()
		{
		}

		public void SetRenderTextureWidth(int width)
		{
		}

		public void SetRenderCameraEnabled(bool render_camera_enabled)
		{
		}

		public void SetDispCameraRenderTexture(bool disp)
		{
		}

		public void SetActiveSkyBox(bool active)
		{
		}
	}
}
