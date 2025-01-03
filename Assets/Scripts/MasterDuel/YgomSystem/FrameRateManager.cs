using UnityEngine;

namespace YgomSystem
{
	public class FrameRateManager : MonoBehaviour
	{
		public enum Mode
		{
			FullFrame = 0,
			Var60 = 1,
			Fix30 = 2,
			Var30 = 3,
			Fix20 = 4
		}

		private static Mode mode;

		private static float highPerfReq;

		private static float rate;

		private static float rate2;

		public static void SetMode(Mode m)
		{
		}

		public static void KeepHighRateMomentary(float time = float.Epsilon)
		{
		}

		private void LateUpdate()
		{
		}
	}
}
