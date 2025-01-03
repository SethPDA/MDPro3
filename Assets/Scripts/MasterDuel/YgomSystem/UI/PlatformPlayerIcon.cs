using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI
{
	public class PlatformPlayerIcon : MonoBehaviour
	{
		private readonly string k_CurrentPlatformIconPath;

		private readonly string k_OtherPlatformIconPath;

		[SerializeField]
		private GameObject m_TargetRoot;

		[SerializeField]
		private Image m_TargetIconImage;

		public void Set(bool isSamePlatfrom)
		{
		}

		private void SetDisp(bool disp)
		{
		}

		private void SetIcon(bool isSamePlatform)
		{
		}
	}
}
