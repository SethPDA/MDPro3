using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using YgomSystem.ElementSystem;

namespace YgomSystem.UI.ElementWidget
{
	public class ToggleGroupWidget : ElementWidgetBase
	{
		private readonly ToggleWidget[] m_ChildToggles;

		private int m_CurrentIdx;

		public int currentIdx
		{
			get
			{
				return 0;
			}
			private set
			{
			}
		}

		public ToggleWidget currentToggle => null;

		public bool selectChildOnCurrentSelected
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public IReadOnlyList<ToggleWidget> childToggles => null;

		public event Action<int> onChangeIdx
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

		public ToggleGroupWidget(ElementObjectManager eom, ToggleWidget[] toggles, int defaultIdx = 0)
			: base(null)
		{
		}

		public void SelectCurrentToggle(bool initializeSelection = false)
		{
		}

		public bool MoveIdx(int idx, bool isLoop = false)
		{
			return false;
		}

		public bool MoveIdxNext(bool isLoop = false)
		{
			return false;
		}

		public bool MoveIdxBack(bool isLoop = false)
		{
			return false;
		}

		public void ResetIdx(int idx)
		{
		}

		public void ResetAllOff()
		{
		}

		private void OnChangedToggleValue(int idx, bool value)
		{
		}

		public void UpdateDefaultItem()
		{
		}
	}
}
