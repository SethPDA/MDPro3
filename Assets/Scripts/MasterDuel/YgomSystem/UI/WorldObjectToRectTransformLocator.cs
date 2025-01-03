using UnityEngine;
using UnityEngine.EventSystems;
using YgomSystem.Effect;

namespace YgomSystem.UI
{
	[ExecuteInEditMode]
	public class WorldObjectToRectTransformLocator : UIBehaviour
	{
		[SerializeField]
		private Camera m_TargetRenderCamera;

		[SerializeField]
		private ScreenEffect.ViewType m_CameraViewType;

		[SerializeField]
		private bool m_CameraOverUI;

		[SerializeField]
		private Transform m_TargetWorldObject;

		private Canvas m_OwnerCanvasCache;

		private RectTransform m_RectTransformCache;

		public Camera targetRenderCamera
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform targetWorldObject
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
	}
}
