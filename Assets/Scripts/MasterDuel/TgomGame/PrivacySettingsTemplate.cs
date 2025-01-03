using UnityEngine;
using UnityEngine.Events;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace TgomGame
{
	public class PrivacySettingsTemplate : MonoBehaviour
	{
		private ElementObjectManager m_EOM;

		private SelectionButton m_LeftButton;

		private SelectionButton m_RightButton;

		private GameObject m_LeftImageOn;

		private GameObject m_LeftImageOff;

		private GameObject m_RightImageOn;

		private GameObject m_RightImageOff;

		private GameObject m_templateObj;

		public bool isLeftButton;

		public bool isRightButton;

		private readonly string LABEL_LEFT_BUTTON;

		private readonly string LABEL_RIGHT_BUTTON;

		private void Awake()
		{
		}

		public void SetParams(int id, string informText, bool leftSelected, bool rightSelected, bool selected)
		{
		}

		public void SetOnClickLeftCallBack(UnityAction callback)
		{
		}

		public void SetOnClickRightCallBack(UnityAction callback)
		{
		}

		public bool OnClickLeft()
		{
			return false;
		}

		public bool OnClickRight()
		{
			return false;
		}
	}
}
