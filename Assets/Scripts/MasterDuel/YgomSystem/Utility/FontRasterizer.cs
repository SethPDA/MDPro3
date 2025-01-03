using System;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.Utility
{
	public class FontRasterizer : MonoBehaviour
	{
		private Action<RenderTexture, Texture2D> onFinish;

		private RenderTextureBuilder renderTexBuilder;

		private Camera cam;

		private RectTransform rootTransform;

		private MDText textComponent;

		private int oldCullingMask;

		private void Awake()
		{
		}

		public void Initialize(int renderTexW, int renderTexH, string text, Action<MDText> onSetup, Action<RenderTexture, Texture2D> onFinish)
		{
		}

		private void OnFinishRender(RenderTextureBuilder renderTexBuilder)
		{
		}
	}
}
