using System.Collections.Generic;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame.Enquete
{
	public class SheetWidgetFactory
	{
		private readonly Transform m_Owner;

		private readonly Dictionary<SheetContentType, ElementObjectManager> m_WidgetTemplates;

		public SheetWidgetFactory(Transform owner)
		{
		}

		public void AssignTemplate(SheetContentType sheetContentType, ElementObjectManager template)
		{
		}

		public ISheetContentWidget Create(ISheetContentContext sheetContentContext, Transform parent)
		{
			return null;
		}

		private ISheetContentWidget SetGroupWidget(ElementObjectManager eom, SheetContentSpacerContext context)
		{
			return null;
		}

		private ISheetContentWidget SetGroupWidget(ElementObjectManager eom, SheetContentGroupContext context)
		{
			return null;
		}

		private ISheetContentWidget SetCaptionWidget(ElementObjectManager eom, SheetContentCaptionContext context)
		{
			return null;
		}

		private ISheetContentWidget SetTextWidget(ElementObjectManager eom, SheetContentTextContext context)
		{
			return null;
		}

		private ISheetContentWidget SetInputAmountWidget(ElementObjectManager eom, SheetContentInputAmountContext context)
		{
			return null;
		}

		private ISheetContentWidget SetInputCheckBoxWidget(ElementObjectManager eom, SheetContentInputCheckBoxContext context)
		{
			return null;
		}

		private ISheetContentWidget SetInputTextWidget(ElementObjectManager eom, SheetContentInputTextContext context)
		{
			return null;
		}

		private ISheetContentWidget SetInputTextConfirmWidget(ElementObjectManager eom, SheetContentInputTextConfirmContext context)
		{
			return null;
		}
	}
}
