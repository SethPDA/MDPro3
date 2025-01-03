using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Enquete
{
	public class InputCheckBoxWidget : SheetContentWidget, ISheetContentCompleteCheckWidget
	{
		public class EntityWidget : SheetContentWidget
		{
			public readonly int idx;

			public readonly ToggleWidget toggle;

			public TMP_Text text => null;

			public event Action<EntityWidget> onChangedValue
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

			public EntityWidget(ElementObjectManager eom, string label, int idx)
				: base(null, null)
			{
			}

			private void OnChangeValue(bool isOn)
			{
			}

			public override void CollectInputValues(Dictionary<string, object> resultValues)
			{
			}
		}

		public readonly EntityWidget[] entityWidgets;

		public readonly int checkMin;

		public readonly int checkMax;

		public int m_LastSelectIdx;

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

		public InputCheckBoxWidget(ElementObjectManager eom, string label, int entityLength, int checkMin, int checkMax)
			: base(null, null)
		{
		}

		private void OnEntityChangeValue(EntityWidget entityWidget)
		{
		}

		public override void CollectSelectionItems(SheetSelectionItemMap sheetSelectionItemMap)
		{
		}

		public override void CollectInputValues(Dictionary<string, object> resultValues)
		{
		}
	}
}
