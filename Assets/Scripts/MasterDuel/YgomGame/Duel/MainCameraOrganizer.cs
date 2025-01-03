using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomGame.Duel
{
	public class MainCameraOrganizer : MonoBehaviour
	{
		private enum Step
		{
			Initializing = 0,
			DuelCameraWork = 1,
			ExecBgCamera = 2,
			EndBgCamera = 3,
			Idle = 4
		}

		public enum ViewMode
		{
			Default = 0,
			DuelTop = 1,
			DuelTopInput = 2,
			Manual = 3,
			DuelTopFar = 4,
			DuelTopInputFar = 5
		}

		[SerializeField]
		private Color _backgroundColorDebug;

		private Step step;

		private CameraShaker camShaker;

		private bool shakeSubCamera;

		private IMainCameraOperation externalOperator;

		private float time;

		private Dictionary<ViewMode, CameraViewSetting.ViewInfo> views;

		private ViewMode currentViewMode;

		private Vector3 gameCamShakedPos;

		private Vector3 gameCamPos;

		private Quaternion gameCamRot;

		private float gameCamFov;

		private float gameCamNearClip;

		private float gameCamFarClip;

		private Vector3 bgCamEndPos;

		private Quaternion bgCamEndRot;

		private float bgCamFov;

		private float bgCamNearClip;

		private float bgCamFarClip;

		private Camera subCamera3D;

		private Camera subCamera2D;

		private Camera screenCamera3D;

		private Camera screenCamera2D;

		private Camera performCamera3D;

		private AudioListener listener;

		private static MainCameraOrganizer _instance;

		private const float bgToGameCamDuration = 2f;

		public CameraViewSetting.ViewInfo view => null;

		public Camera camera3D
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

		public Camera uiCameraContent
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

		public Camera uiCameraOverlay
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

		public bool cameraWorkFinish
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static MainCameraOrganizer instance => null;

		public bool isInitialized
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

		private void Awake()
		{
		}

		public static MainCameraOrganizer Create(GameObject root, string name)
		{
			return null;
		}

		public void Initialize()
		{
		}

		public void SetupViews()
		{
		}

		public void InitializeToDuel(bool isAudience)
		{
		}

		public void FinishToDuel()
		{
		}

		public void Reboot()
		{
		}

		public void PrepareToDuel(bool bgCameraEnabled)
		{
		}

		public void CameraWorkBegin(Camera camera)
		{
		}

		public void CameraWorkEnd()
		{
		}

		public void SetViewMode(ViewMode viewMode, bool immediate = true, bool isDuelAudience = false)
		{
		}

		public void Shake(string type, bool shakeSubCamera = false)
		{
		}

		public void SetActivePostProcessing(bool active)
		{
		}

		public void SetExternalOperator(IMainCameraOperation externalOperator)
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		private void InitializingStep()
		{
		}

		private void DuelStartShow()
		{
		}

		private void ExecBgCameraStep()
		{
		}

		private void EndBgCameraStep()
		{
		}

		private void IdleStep()
		{
		}

		private void UpdateGameCam(float lerpT = 0.5f)
		{
		}
	}
}
