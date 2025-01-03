using System;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.DuelLive
{
	public class ProductContainerWidget : ElementWidgetBase
	{
		public readonly ProductWidget[] productWidgets;

		public Action<ProductContainerWidget, ProductWidget> onClickCallback;

		public ProductContainerWidget(ElementObjectManager eom, ElementObjectManager productPref, int contentLength)
			: base(null)
		{
		}

		private void OnClick(ProductWidget clickedWidget)
		{
		}
	}
}
