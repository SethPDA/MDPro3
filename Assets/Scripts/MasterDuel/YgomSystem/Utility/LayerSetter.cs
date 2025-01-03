using UnityEngine;

namespace YgomSystem.Utility
{
	public class LayerSetter : MonoBehaviour
	{
		public enum Layer
		{
			Default = 0,
			Overlay3D = 1,
			Overlay2D = 2,
			OverlayEffect3D = 3,
			OverlayEffect2D = 4
		}

		[SerializeField]
		private Layer _layer;

		[SerializeField]
		private bool _autoUpdate;

		[SerializeField]
		private bool _setOnAwake;

		public Layer layer
		{
			get
			{
				return default(Layer);
			}
			set
			{
			}
		}

		public bool autoUpdate
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool setOnAwake
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void Update()
		{
		}

		public void Apply()
		{
		}

		public void SetLayer(Layer layer)
		{
		}

		public static int GetLayer(Layer layer)
		{
			return 0;
		}
	}
}
