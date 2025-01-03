using UnityEngine;

namespace YgomSystem
{
	public class SafeAreaScreen : MonoBehaviour
	{
		public enum Mode
		{
			None = 0,
			SafeArea = 1,
			MinOnly = 2,
			MaxOnly = 3,
			MinOutside = 4,
			MaxOutside = 5
		}

		[SerializeField]
		private Mode verticalMode;

		[SerializeField]
		private Mode horizontalMode;

		[SerializeField]
		private bool fillRectTransformOnApplySafeArea;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void SetSafeArea()
		{
		}
	}
}
