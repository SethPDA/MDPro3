using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using YgomSystem.ElementSystem;

namespace YgomGame.Enquete
{
	public class GroupWidget : SheetContentWidget, ISheetContentCompleteCheckWidget
	{
		private readonly SheetWidgetFactory m_SheetWidgetFactory;

		public readonly List<ISheetContentWidget> m_ContentWidgets;

		public readonly List<ISheetContentCompleteCheckWidget> m_ContentCompleteCheckWidgets;

		public bool isMust;

		public bool isInputComplete
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

		public event Action onChangeComplete
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

		public GroupWidget(ElementObjectManager eom, string label, SheetWidgetFactory sheetWidgetFactory)
			: base(null, null)
		{
		}

		public void SetContents(List<ISheetContentContext> contents)
		{
		}

		public override void ImportInputValues(Dictionary<string, object> importValues)
		{
		}

		public override void CollectSelectionItems(SheetSelectionItemMap sheetSelectionItemMap)
		{
		}

		public override void CollectInputValues(Dictionary<string, object> resultValues)
		{
		}

		private void CheckInputComplete()
		{
		}
	}
}
