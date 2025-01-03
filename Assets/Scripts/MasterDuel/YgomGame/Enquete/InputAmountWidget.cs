using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Enquete
{
	public class InputAmountWidget : SheetContentWidget, ISheetContentCompleteCheckWidget
	{
		public class ToggleWidget : SheetContentWidget
		{
			public readonly YgomSystem.UI.ElementWidget.ToggleWidget toggle;

			public readonly int idx;

			public event Action<ToggleWidget> onChangedValue
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

			public ToggleWidget(ElementObjectManager eom, int idx)
				: base(null, null)
			{
			}

			private void OnChangeValue(bool isOn)
			{
			}
		}

		public readonly ToggleWidget[] toggleWidgets;

		public int currentAmount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public TMP_Text minText => null;

		public TMP_Text maxText => null;

		public bool isInputComplete => false;

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

		public InputAmountWidget(ElementObjectManager eom, string label, int amountLength)
			: base(null, null)
		{
		}

		private void OnToggleChangeValue(ToggleWidget toggle)
		{
		}

		public override void CollectInputValues(Dictionary<string, object> resultValues)
		{
		}

		public override void CollectSelectionItems(SheetSelectionItemMap sheetSelectionItemMap)
		{
		}
	}
}
