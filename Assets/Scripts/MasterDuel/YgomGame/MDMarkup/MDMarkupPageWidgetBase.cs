using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using YgomGame.Utility;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.MDMarkup
{
	public class MDMarkupPageWidgetBase : MDMarkupWidgetBase//, IMDMarkupPageWidget, IMDMarkupGraphWidget
	{
		private readonly string k_ELabelCaption;

		private readonly string k_ELabelText;

		private readonly string k_ELabelImage;

		private readonly string k_ELabelMarkupRoot;

		private readonly string k_ELabelButtonFormat;

		public readonly GameObject m_ImageTarget;

		public readonly TextMeshProUGUI m_CaptionText;

		public readonly TextMeshProUGUI m_Text;

		public readonly Transform m_MarkupRoot;

		public readonly List<SelectionButton> buttons;

		private List<SelectionButton> YgomGame_002EMDMarkup_002EIMDMarkupPageWidget_002Ebuttons => null;

		public event Action<bool> onFocusPageEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public MDMarkupPageWidgetBase(ElementObjectManager eom, MDMarkupIndentWidget indentWidget)
			: base(null, null)
		{
		}

		public override void BindContentData(IMDMarkupContent mdMarkupContent)
		{
		}

		public void OutputMarkupGraph(IMDMarkupContent mdMarkupContent, MDMarkupGraphFactory markupGraphFactory, Action onComplete)
		{
		}

		protected virtual GlobalTextData GetCaptionText(IMDMarkupContent mdMarkupContent)
		{
			return null;
		}

		protected virtual GlobalTextData GetText(IMDMarkupContent mdMarkupContent)
		{
			return null;
		}

		protected virtual MDMarkupBannerContext GetBannerContext(IMDMarkupContent mdMarkupContent)
		{
			return null;
		}

		protected virtual string GetResourcePath(IMDMarkupContent mdMarkupContent)
		{
			return null;
		}

		protected virtual List<URLSchemeButton> GetButtons(IMDMarkupContent mdMarkupContent)
		{
			return null;
		}

		protected virtual List<IMDMarkupContent> GetMarkupContents(IMDMarkupContent mdMarkupContent)
		{
			return null;
		}

		public void OnFocusPage(bool isFirst)
		{
		}
	}
}
