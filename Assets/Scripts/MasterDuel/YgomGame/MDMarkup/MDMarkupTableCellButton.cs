using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine.Events;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.MDMarkup
{
	public class MDMarkupTableCellButton : ElementWidgetBase, IMDMarkupLinkWidget, IMDMarkupButtonWidget, IMDMarkupTMPWidget
	{
		private readonly string k_ELabelButton;

		private readonly string k_ELabelText;

		public readonly TMP_Text text;

		public bool borderVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public SelectionButton button
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

		public string link
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

		public MDMarkupTableCellButton(ElementObjectManager eom)
			: base(null)
		{
		}

		public void SetText(string text)
		{
		}

		public void SetLink(string link)
		{
		}

		public void SetAlignment(TextAlignmentOptions alignment)
		{
		}

		public void SetSizeRate(float sizeRate)
		{
		}

		public void SetOnClick(UnityAction callback)
		{
		}

		public void AddContainTMPTexts(List<TMP_Text> results)
		{
		}
	}
}
