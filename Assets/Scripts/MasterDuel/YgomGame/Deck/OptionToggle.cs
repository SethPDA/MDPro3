using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Deck
{
	public class OptionToggle : MonoBehaviour
	{
		private string m_ButtonLabel;

		private UnityAction m_OnClickAction;

		private const string LABEL_SBN_BODY = "Body";

		private const string LABEL_RT_IMAGEOFF = "ImageOff";

		private const string LABEL_TXT_ITEMTEXT = "TextItem";

		private const string LABEL_RT_IMAGEON = "ImageOn";

		private const string LABEL_TXT_DESCTEXT = "TextDescription";

		private bool isOn;

		private ElementObjectManager m_eom => null;

		private RectTransform m_Off => null;

		private RectTransform m_On => null;

		private MDText m_DescText => null;

		private MDText m_ItemText => null;

		private void toggle()
		{
		}

		public void Initialize(string title, string desc, bool b)
		{
		}

		public string GetButtonLabel()
		{
			return null;
		}

		public bool GetEnabledState()
		{
			return false;
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void SetOnClickCallback(UnityAction callback)
		{
		}

		public SelectionButton GetButton()
		{
			return null;
		}
	}
}
