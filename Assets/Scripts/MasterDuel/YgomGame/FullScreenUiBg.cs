using UnityEngine;
using UnityEngine.Events;
using YgomSystem.UI;

namespace YgomGame
{
	public class FullScreenUiBg : MonoBehaviour
	{
		private const string PREFAB_PATH = "Prefabs/VC/Utility/FullScreenUIBg";

		private UiSwitchTweenAnimationController m_UiSwitchTweenAnimationController;

		private bool m_IsShow_Current;

		private bool m_IsShow_Next;

		public static void Create(Transform parent, UnityAction<FullScreenUiBg> onFinished)
		{
		}

		private void Initialize()
		{
		}

		public void Show()
		{
		}

		public void Close()
		{
		}
	}
}
