using System;
using System.Collections.Generic;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Shop
{
	public class ProductContainerWidget : ElementWidgetBase
	{
		public class Context
		{
			public readonly List<ProductContext> productCtxs;

			public int Count => 0;

			public Context(int capacity)
			{
			}

			public void Clear()
			{
			}

			public void Add(string productWidgetLabel, ProductContext productCtx)
			{
			}
		}

		private List<ProductWidget> m_ActiveWidgets;

		private Dictionary<string, List<ProductWidget>> m_HoldWidgetsMap;

		public Action<ProductWidget, ProductContext> onUpdateContentWidget;

		public Action<ProductWidget, int> onClickCallback;

		public Action<ProductWidget, int> onSelectedCallback;

		public List<ProductWidget> productWidgets => null;

		public ProductContainerWidget(ElementObjectManager eom)
			: base(null)
		{
		}

		public void ApplyContents(ProductWidgetController widgetController, Context ctx, IProductContainerWidgetHandler handler, Action<ProductWidget> onReturnWidget = null)
		{
		}
	}
}
