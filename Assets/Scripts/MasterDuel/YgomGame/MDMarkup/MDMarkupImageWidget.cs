using UnityEngine.UI;
using YgomSystem.ElementSystem;

namespace YgomGame.MDMarkup
{
	public class MDMarkupImageWidget : MDMarkupWidgetBase
	{
		private readonly string k_ELabelImage;

		public readonly Image m_Image;

		private bool m_IsReady;

		public override bool isReady => false;

		public MDMarkupImageWidget(ElementObjectManager eom, MDMarkupIndentWidget indentWidget)
			: base(null, null)
		{
		}

		public override void BindContentData(IMDMarkupContent mdMarkupContent)
		{
		}

		public override void OnReady()
		{
		}
	}
}
