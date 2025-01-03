using MDPro3;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomSystem.Effect
{
	public class ScreenEffect : MonoBehaviour
	{
		public enum ViewType
		{
			View2D = 0,
			View3D = 1
		}

		public bool useCameraSetting;

		public bool useMainCameraSetting;

		public Vector3 cameraPosition;

		public Vector3 cameraAngle;

		public ViewType cameraViewType;

		public float camera2DSize;

		public bool overUI;

		public bool setupOnAwake;

		public Camera targetCamera
		{
			//[CompilerGenerated]
			get
			{
                if (cameraViewType == ViewType.View3D)
				{
					if(cameraAngle == Vector3.zero)
                        return Program.instance.camera_.cameraDuelOverlayEffect3D;
                    else
                        return Program.instance.camera_.cameraDuelOverlay3D;
                }
                else
				{
                    if (overUI)
                        return Program.instance.camera_.cameraDuelOverlayEffect2D;
					else
                        return Program.instance.camera_.cameraDuelOverlay2D;
                }
            }
			//[CompilerGenerated]
			private set
			{
			}
		}

		private void OnEnable()
		{
			Setup();
        }

        public void Setup()
		{
            if (useMainCameraSetting)
            {
                cameraViewType = ViewType.View3D;
                cameraPosition = CameraManager.mainCameraDefaultPosition;
                cameraAngle = CameraManager.mainCameraDefaultRotation;
                overUI = false;
            }

            if (targetCamera == Program.instance.camera_.cameraDuelOverlayEffect2D)
			{
                CameraManager.DuelOverlayEffect2DPlus();
				SetupLayer("DuelOverlayEffect2D");
            }
            else if (targetCamera == Program.instance.camera_.cameraDuelOverlay2D)
			{
                CameraManager.DuelOverlay2DPlus();
                SetupLayer("DuelOverlay2D");
            }
            else if (targetCamera == Program.instance.camera_.cameraDuelOverlayEffect3D)
			{
                CameraManager.DuelOverlayEffect3DPlus();
                SetupLayer("DuelOverlayEffect3D");
            }
            else if (targetCamera == Program.instance.camera_.cameraDuelOverlay3D)
			{
                CameraManager.DuelOverlay3DPlus();
                SetupLayer("DuelOverlay3D");
            }
            SetupCamera(targetCamera);
        }

        public void SetupCamera(Camera target)
		{
            if (target == Program.instance.camera_.cameraDuelOverlay3D && CameraManager.overlaySticking)
                return;
			target.transform.localPosition = cameraPosition;
			target.transform.localEulerAngles = cameraAngle;
			if (target.name.Contains("2D"))
			{
                target.orthographicSize = camera2DSize;
            }
        }

        public void TraceCameraSetting(Camera target, string viewInfoLabel = "Top")
		{
		}

		public static void TraceMainCameraSetting(Camera target)
		{
		}

		public void SetupLayer(int layer)
		{
		}
        public void SetupLayer(string layerName)
        {
			Tools.ChangeLayer(gameObject, layerName);
        }

        public void SetupSpriteScaler()
		{
		}

		public void SetupSpriteScaler(float screenWidth, float screenHeight, Camera setupCamera = null)
		{
		}

        private void OnDisable()
        {
            if (targetCamera == Program.instance.camera_.cameraDuelOverlayEffect2D)
            {
                CameraManager.DuelOverlayEffect2DMinus();
            }
            else if (targetCamera == Program.instance.camera_.cameraDuelOverlay2D)
            {
                CameraManager.DuelOverlay2DMinus();
            }
            else if (targetCamera == Program.instance.camera_.cameraDuelOverlayEffect3D)
            {
                CameraManager.DuelOverlayEffect3DMinus();
            }
            else if (targetCamera == Program.instance.camera_.cameraDuelOverlay3D)
            {
                CameraManager.DuelOverlay3DMinus();
            }
        }
    }
}
