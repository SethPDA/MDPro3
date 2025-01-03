using System;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.Utility
{
	public class RenderTextureBuilder : MonoBehaviour
	{
		public int textureW;

		public int textureH;

		public int depth;

		public RenderTexture texture;

		public RawImage targetRawImage;

		public int snapshotDelay;

		public bool snapshotAndDestroy;

		public Action<RenderTextureBuilder> snapshotAction;

		public bool useHDRFormat;

		public int antiAliasing;

		private Camera renderCamera;

		public void Restart()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnPostRender()
		{
		}
	}
}
