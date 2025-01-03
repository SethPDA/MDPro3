using UnityEngine;
using UnityEngine.Events;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Duel
{
	public class PhaseSelectWindow : MonoBehaviour
	{
		private const string LABEL_EO_WINDOW = "Window";

		private const string LABEL_EO_CONTENT = "Content";

		private const string LABEL_EO_BUTTON_CLOSE = "ButtonClose";

		private const string LABEL_EO_BUTTONPHASE = "ButtonPhase";

		private const string LABEL_EO_TEXTTITLE = "TextTitle";

		private const string LABEL_TW_IN = "In";

		private const string LABEL_TW_OUT = "Out";

		private const string LABEL_TW_CURRENT = "Current";

		private const string LABEL_TW_NORMAL = "Normal";

		private const string LABEL_TW_SELECT = "select";

		private DuelClient m_Host;

		private ElementObjectManager m_RootManager;

		private SelectionButton m_ButtonClose;

		private SelectionButton[] m_ButtonPhases;

		private const int m_PhaseNum = 6;

		public bool isOpened => false;

		public static void Create(DuelClient host, Transform parent, UnityAction<PhaseSelectWindow> onFinish)
		{
		}

		private void Initialize(DuelClient host)
		{
		}

		private void SetPhaseButton()
		{
		}

		public void OpenWindow()
		{
		}

		public void CloseWindow()
		{
		}
	}
}
