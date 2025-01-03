using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.MDMarkup
{
	public class MDMarkupTableCellImage : ElementWidgetBase, IMDMarkupAsyncWidget
	{
		private readonly string k_ELabelImage;

		private readonly Image m_Image;

		public readonly LayoutElement m_LayoutElement;

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

		public Image image => null;

		public bool isReady
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

		public MDMarkupTableCellImage(ElementObjectManager eom)
			: base(null)
		{
		}

		public void SetSprite(string imagePath, float overrideHeight = 0f)
		{
		}

		public void SetAlignment(TextAlignmentOptions alignment)
		{
		}

		public void SetSizeRate(float sizeRate)
		{
		}

		public void OnReady()
		{
		}
	}
}
