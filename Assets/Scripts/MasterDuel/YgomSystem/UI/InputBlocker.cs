using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI
{
	public class InputBlocker : MonoBehaviour
	{
		[SerializeField]
		private Graphic m_GameMaxRaycastBlocker;

		private int m_BlockCounter;

		public bool isBlocked => false;

		private void Awake()
		{
		}

		private void Clear()
		{
		}

		public void Reboot()
		{
		}

		public void SetBlockEnabled(bool enabled)
		{
		}
	}
}
