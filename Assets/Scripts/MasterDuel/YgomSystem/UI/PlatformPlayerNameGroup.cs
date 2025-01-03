using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI
{
	public class PlatformPlayerNameGroup : MonoBehaviour
	{
		private readonly string k_CurrentPlatformIconPath;

		[SerializeField]
		private TMP_Text m_YmdPlayerNameText;

		[SerializeField]
		private GameObject m_PlatformNameRoot;

		[SerializeField]
		private TMP_Text m_PlatformPlayerNameText;

		[SerializeField]
		private Image m_PlatformPlayerIcon;

		[SerializeField]
		private bool m_IsDispPcode;

		public void Set(string ymdPlayerName, string platformPlayerName, long pcode, bool isRegistedPlatform)
		{
		}

		public string GetYmdPlayerName()
		{
			return null;
		}
	}
}
