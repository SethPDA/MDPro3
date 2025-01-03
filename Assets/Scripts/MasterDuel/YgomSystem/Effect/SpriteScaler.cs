using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomSystem.Effect
{
	public class SpriteScaler : MonoBehaviour
	{
		public enum FitMode
		{
			None = 0,
			FitWidth = 1,
			FitHeight = 2,
			FitWidthMaintainAspectRatio = 3,
			FitHeightMaintainAspectRatio = 4,
			FitWidthHeight = 5,
			FitHighestResolutionMaintainAspectRatio = 6,
			FitLowestResolutionMaintainAspectRatio = 7
		}

		[SerializeField]
		private bool applyOnUpdate;

		[SerializeField]
		private FitMode fitMode;

		[SerializeField]
		public Vector3 offsetScale;

		[SerializeField]
		private bool _useDirectSizeSetting;

		[SerializeField]
		private Vector2 _directSizeSetting;

		[SerializeField]
		private bool _changePosition;

		[SerializeField]
		private bool _isUseFixedDepth;

		[SerializeField]
		private float _fixedDepth;

		private SpriteRenderer targetSprite;

		private SpriteMask targetMask;

		private bool isApplied;

		private bool applyOnCustomSize;

		private Vector2 appliedScreenSize;

		public bool isApplyOnUpdate
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool useDirectSizeSetting
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Vector2 directSizeSetting
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public bool changePosition
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool useFixedDepth
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float fixedDepth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Camera viewCamera
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

		public void SetFitMode(FitMode fitMode)
		{
		}

		public void Setup(Camera view_camera)
		{
		}
        private void Awake()
        {
			Apply();
        }

        public void Apply()
		{
			var widthScale = transform.localScale.x;
			var heightScale = transform.localScale.y;
			var z = transform.localScale.z;
            if (fitMode == FitMode.FitWidth)
			{
				var x = widthScale * (Screen.width * 9f / (Screen.height * 16f));
				transform.localScale = new Vector3(x, heightScale, z);
			}
			else if(fitMode == FitMode.FitHeight)
			{
				var y = heightScale * (Screen.height * 16f / (Screen.width * 9f));
				transform.localScale=new Vector3(widthScale, y, z);
			}
            else if (fitMode == FitMode.FitWidthMaintainAspectRatio)
            {
				if(name == "SpliteDummy" || name == "White")
				{
					var x = widthScale * (Screen.width * 9f / (Screen.height * 16f));
					transform.localScale = new Vector3(x, heightScale * x / widthScale, z);
				}
				else if(name == "Black")
				{
					widthScale = 15f * (Screen.width * 9f / (Screen.height * 16f));
					transform.localScale = new Vector3(widthScale, widthScale, z);
				}
            }
            else if (fitMode == FitMode.FitHeightMaintainAspectRatio)
            {
				heightScale = 6f;
                transform.localScale = new Vector3(heightScale, heightScale, z);
            }
            else if (fitMode == FitMode.FitWidthHeight)
            {
                var x = heightScale * Screen.width / Screen.height;
                transform.localScale = new Vector3(x * 1.1f, heightScale, z);
				if (transform.parent != null && transform.parent.name.StartsWith("Ef04678"))
                    transform.localScale = new Vector3(x * 2f, heightScale * 2f, z);
            }
        }

        public void Apply(float screenWidth, float screenHeight)
		{
		}

		public void Reapply()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}
	}
}
