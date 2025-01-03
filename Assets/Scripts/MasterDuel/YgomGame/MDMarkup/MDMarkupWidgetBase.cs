using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.MDMarkup
{
	public abstract class MDMarkupWidgetBase : ElementWidgetBase//, IMDMarkupWidget, IMDMarkupAsyncWidget
	{
		public readonly MDMarkupIndentWidget indentWidget;

		private MDMarkupIndentWidget YgomGame_002EMDMarkup_002EIMDMarkupWidget_002EindentWidget => null;

		public virtual bool isReady => false;

		public MDMarkupWidgetBase(ElementObjectManager eom, MDMarkupIndentWidget indentWidget)
			: base(null)
		{
		}

		public abstract void BindContentData(IMDMarkupContent mdMarkupContent);

		public virtual void OnReady()
		{
		}
	}
}
