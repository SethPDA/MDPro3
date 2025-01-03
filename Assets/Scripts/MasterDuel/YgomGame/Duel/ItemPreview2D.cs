using System;
using UnityEngine;
using UnityEngine.UI;

namespace YgomGame.Duel
{
	public class ItemPreview2D : MonoBehaviour
	{
		[SerializeField]
		public RawImage rawImg;

		private int id;

		private GameObject itemObject;

		public Camera renderCam;

		public static void Create(Transform parent, Action<ItemPreview2D> onFinish = null)
		{
		}

		public static void Create(GameObject gameObject, Transform parent, Vector3 modelPos, Vector3 modelRot, Vector3 modelScale, Vector3 camPos, Vector3 camRot, int renderTexW = 256, int renderTexH = 256, float imgW = -1f, float imgH = -1f, Action<ItemPreview2D> onFinish = null, bool enablePostEffect = false)
		{
		}

		private void Initialize(GameObject gameObject, Vector3 modelPos, Vector3 modelRot, Vector3 modelScale, Vector3 camPos, Vector3 camRot, int renderTexW = 256, int renderTexH = 256, float imgW = -1f, float imgH = -1f, Action onFinish = null, bool enablePostEffect = false)
		{
		}

		public void LookAtItemObject()
		{
		}

		public void OnDestroy()
		{
		}

		private void OnDisable()
		{
		}

		private void OnEnable()
		{
		}
	}
}
