using System;
using UnityEngine;

namespace YgomSystem.UI
{
	[Serializable]
	public class SelectionTransitionSetting
	{
		[SerializeField]
		private SelectionItem.TransitionMode m_Mode;

		[SerializeField]
		private SelectionItem m_ManualItem;

		[SerializeField]
		private Selector m_ManualSelector;

		public SelectionItem.TransitionMode mode
		{
			get
			{
				return default(SelectionItem.TransitionMode);
			}
			set
			{
			}
		}

		public SelectionItem manualItem
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Selector manualSelector
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void SetTransitionSetting(PadInputDirection direction, SelectionItem target)
		{
		}
	}
}
