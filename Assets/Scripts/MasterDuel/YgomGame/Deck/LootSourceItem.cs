using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomGame.Card;
using YgomGame.Utility;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Deck
{
	public class LootSourceItem : MonoBehaviour
	{
		private const string LABEL_SBN_BUTTON = "Button";

		private const string LABEL_TXT_SOURCETEXT = "TextSource";

		private const string LABEL_TXT_TITLETEXT = "TextTitle";

		private const string LABEL_RT_IMAGESUMMARY = "ImageSummary";

		private const string LABEL_IMG_IMAGESUMMARY = "ImageSummary";

		private const string LABEL_RT_ON = "On";

		private const string LABEL_RT_OFF = "Off";

		private const string LABEL_RT_MASK = "Mask";

		protected UnityAction m_OnClickAction;

		protected UnityAction m_OnSelectedAction;

		protected UnityAction m_OnDeselectedAction;

		protected UnityAction<bool> m_OnRightClickAction;

		protected UnityAction m_SelectedKeySub1Action;

		protected UnityAction m_SelectedKeyLeftAction;

		protected UnityAction m_SelectedKeyL2Action;

		public LootSourceInfo.LootCategory m_Category
		{
			[CompilerGenerated]
			get
			{
				return default(LootSourceInfo.LootCategory);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string m_StringID
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool m_IsAvailable
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private ElementObjectManager m_eom => null;

		private SelectionButton m_Button => null;

		private ExtendedTextMeshProUGUI m_SourceText => null;

		private ExtendedTextMeshProUGUI m_TitleText => null;

		private RectTransform m_ImageSummary => null;

		private Image m_ImageSummaryIMG => null;

		private RectTransform m_On => null;

		private RectTransform m_Off => null;

		private RectTransform m_Mask => null;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void SetData(LootSourceInfo.LootCategory cat, string title, string source, int param, bool available, int iconType = 0, string iconData = null, TextGroupLoadHolder textGroupLoadHolder = null)
		{
		}

		private void SetImageSummary(LootSourceInfo.LootCategory cat, int param = 0, string iconData = null)
		{
		}

		public void ToggleAvailability(bool b)
		{
		}

		public void ToggleAllow()
		{
		}

		public void SetOnSelectedCallback(UnityAction callback)
		{
		}

		public void SetOnDeselectedCallback(UnityAction callback)
		{
		}

		public void SetOnClickCallback(UnityAction callback)
		{
		}

		public void SetOnRightClickCallback(UnityAction<bool> callback)
		{
		}

		public void SetOnSelectedKeySub1Callback(UnityAction callback)
		{
		}

		public void SetOnSelectedKeyLeftCallback(UnityAction callback)
		{
		}

		public void SetOnSelectedKeyL2Callback(UnityAction callback)
		{
		}
	}
}
