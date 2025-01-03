using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using YgomSystem.LocalizedFont;

namespace YgomSystem.UI
{
	public sealed class ExtendedInputField : InputField, ILocalizedFontOwner
	{
		[SerializeField]
		private LocalizedFontSettingsBase.FontType m_localizedFontType;

		[SerializeField]
		private int m_localizedFontMaterialIndex;

		private Event m_ProcessingEvent;

		private int preAnchor;

		private int preFocus;

		private string preText;

		public LocalizedFontSettingsBase.FontType localizedFontType
		{
			get
			{
				return default(LocalizedFontSettingsBase.FontType);
			}
			set
			{
			}
		}

		public int localizedFontMaterialIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		protected override void Start()
		{
		}

		//public override void OnSelect(BaseEventData eventData)
		//{
		//}

		//public override void OnUpdateSelected(BaseEventData eventData)
		//{
		//}
	}
}
