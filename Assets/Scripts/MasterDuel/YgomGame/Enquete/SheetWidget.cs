using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace YgomGame.Enquete
{
	public class SheetWidget
	{
		public readonly GameObject gameObject;

		public readonly RectTransform rectTransform;

		private readonly SheetWidgetFactory m_SheetWidgetFactory;

		public readonly List<ISheetContentWidget> m_ContentWidgets;

		public readonly List<ISheetContentCompleteCheckWidget> m_ContentCompleteCheckWidgets;

		public readonly SheetSelectionItemMap selectionItemMap;

		public bool isMust
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

		public IReadOnlyList<ISheetContentWidget> contentWidgets => null;

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

		public SheetWidget(RectTransform rectTransform, SheetWidgetFactory sheetWidgetFactory)
		{
		}

		public void SetContext(SheetContext sheetContext)
		{
		}

		public void CollectInputValues(Dictionary<string, object> resultValues)
		{
		}

		private void CheckInputComplete()
		{
		}
	}
}
