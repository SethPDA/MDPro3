using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.CameraSystem
{
	public class CameraRenderTargetUI : MonoBehaviour
	{
		public RawImage mainCameraRenderTarget
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

		public static CameraRenderTargetUI instance
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private void Awake()
		{
		}

		public void Setup(RenderTexture render_texture)
		{
		}

		public void SetDisp(bool active)
		{
		}
	}
}
