using System;
using UnityEngine;
using YgomSystem.Utility;

namespace YgomSystem.UI
{
	public class RenderTextureTarget : MonoBehaviour
	{
		[SerializeField]
		private RenderTextureBuilder renderTexBuilder;

		[SerializeField]
		private Transform rootTransform;

		[SerializeField]
		private Camera cam;

		private Action<int, RenderTexture, Texture2D> onFinish;

		private int oldCullingMask;

		[SerializeField]
		private int renderDelay;

		public int renderTargetId;

		private GameObject targetObject;

		public Camera Cam => null;

		public static int Create(GameObject obj, Vector3 camPos, Vector3 camRot, int renderTexW = 256, int renderTexH = 256, Action<int, RenderTexture, Texture2D> onFinish = null, bool enablePostEffect = false, int depth = 24)
		{
			return 0;
		}

		public static void Destory(int id)
		{
		}

		public void DestroyRenderTexture()
		{
		}

		public void ResetOnFinish()
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Initialize(int renderTexW, int renderTexH, Action<int, RenderTexture, Texture2D> onFinish, int depth = 24, bool enablePostEffect = false)
		{
		}

		private void OnFinishRender(RenderTextureBuilder renderTexBuilder)
		{
		}

		private void InitBuilder()
		{
		}
	}
}
