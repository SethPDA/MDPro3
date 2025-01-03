using UnityEngine;

namespace YgomGame.Duel
{
	public class BezierMotionTest : MonoBehaviour
	{
		private enum CameraMode
		{
			Top = 0,
			Motion = 1
		}

		[SerializeField]
		private BezierMotionSetting[] setting;

		[SerializeField]
		private CameraViewSetting cameraViewSetting;

		[SerializeField]
		private GameObject originPositionObj;

		[SerializeField]
		private GameObject targetPositionObj;

		[SerializeField]
		private GameObject startObj;

		[SerializeField]
		private GameObject viaObj;

		[SerializeField]
		private GameObject endObj;

		[SerializeField]
		private GameObject motionObj;

		[SerializeField]
		private float timer;

		[SerializeField]
		private bool autoUpdateTimer;

		[SerializeField]
		private GameObject[] prefabBg;

		private ChainedBezierMotion motion;

		[SerializeField]
		private CameraMode cameraMode;

		private CameraMode preCameraMode;

		[SerializeField]
		private bool loop;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
