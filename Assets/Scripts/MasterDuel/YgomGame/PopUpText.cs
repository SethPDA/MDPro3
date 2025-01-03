using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.YGomTMPro;

namespace YgomGame
{
	public class PopUpText : MonoBehaviour
	{
		[SerializeField]
		private int m_FontSizeForString;

		[SerializeField]
		private int m_FontSizeForNumber;

		[SerializeField]
		private int m_FontSizeForString_Mobile;

		[SerializeField]
		private int m_FontSizeForNumber_Mobile;

		private Queue<string> m_TaskQueue;

		private bool m_Showing;

		private Image m_PopUpBaseNW;

		private Image m_PopUpBaseNE;

		private Image m_PopUpBaseSW;

		private Image m_PopUpBaseSE;

		private ElementObjectManager m_EOManager;

		private ExtendedTextMeshProUGUI m_PopUpText;

		private ExtendedTextMeshProUGUI m_PopUpText_Preset;

		private RectTransform m_Rt;

		private bool m_Isforui;

		private Vector3 m_WorldPos;

		private bool m_UpdateSize;

		public UnityAction onClosed;

		public bool IsShowing => false;

		public void SetEnable(bool enable)
		{
		}

		public void ShowText(string text, Vector3 worldPos, bool isforui)
		{
		}

		public void HideText()
		{
		}

		public void UpdateText(string text)
		{
		}

		public void Initialize(UnityAction onClosedEvent)
		{
		}

		private void UpdatePosition()
		{
		}

		private void Update()
		{
		}
	}
}
