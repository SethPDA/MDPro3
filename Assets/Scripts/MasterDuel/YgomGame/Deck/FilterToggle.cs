using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Deck
{
	public class FilterToggle : MonoBehaviour
	{
		private UnityAction m_OnClickAction;

		private const string LABEL_RT_IMAGEOFF = "ImageOff";

		private const string LABEL_RT_IMAGEON = "ImageOn";

		private const string LABEL_TXT = "Text";

		private ElementObjectManager m_Eom;

		private RectTransform m_Off;

		private RectTransform m_On;

		private ExtendedTextMeshProUGUI m_TextTMP;

		private bool isInitilaized;

		public bool isOn
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string m_Label
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public SelectionButton m_Button
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private void InitializeElements()
		{
		}

		public void Initialize(string label, string text, bool isOn)
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Toggle()
		{
		}

		public void SetOn(bool isOn)
		{
		}

		public void SetOnClickCallback(UnityAction callback)
		{
		}
	}
}
