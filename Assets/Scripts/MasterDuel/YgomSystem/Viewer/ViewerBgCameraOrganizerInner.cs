using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using YgomGame.Duel;

namespace YgomSystem.Viewer
{
	public class ViewerBgCameraOrganizerInner : MonoBehaviour
	{
		public enum ViewMode
		{
			DuelTop = 0,
			DuelTopFar = 1
		}

		public enum DisplayType
		{
			Vista = 0,
			Standard = 1,
			MobileDevice = 2
		}

		private Action externalOperator;

		private float time;

		private Dictionary<DisplayType, Dictionary<ViewMode, CameraViewSetting.ViewInfo>> views;

		private ViewMode currentViewMode;

		private DisplayType currentDisplayType;

		private Vector3 gameCamShakedPos;

		private Vector3 gameCamPos;

		private Quaternion gameCamRot;

		private float gameCamFov;

		private float gameCamNearClip;

		private float gameCamFarClip;

		public Camera camera3D;

		public Camera subCamera3D;

		public Camera subCamera2D;

		public Camera screenCamera3D;

		public Camera screenCamera2D;

		public Camera performCamera3D;

		public Camera uiCameraContent;

		public Camera uiCameraOverlay;

		private static ViewerBgCameraOrganizerInner _instance;

		public CameraViewSetting.ViewInfo view => null;

		public bool cameraWorkStart
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool cameraWorkFinish
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static ViewerBgCameraOrganizerInner instance => null;

		public void Initialize()
		{
		}

		public void SetupViews()
		{
		}

		public void InitializeToDuel()
		{
		}

		public void SetViewMode(ViewMode viewMode, bool immediate = true)
		{
		}

		public void SetDisplayType(DisplayType displayType, bool immediate = true)
		{
		}

		public void SetActivePostProcessing(bool active)
		{
		}

		public void SetExternalOperator(Action externalOperator)
		{
		}

		private void Update()
		{
		}

		private void UpdateGameCam(float lerpT = 0.5f)
		{
		}
	}
}
