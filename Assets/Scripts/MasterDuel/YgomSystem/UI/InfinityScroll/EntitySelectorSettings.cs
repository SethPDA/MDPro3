using System;
using UnityEngine;

namespace YgomSystem.UI.InfinityScroll
{
	[Serializable]
	public class EntitySelectorSettings
	{
		[SerializeField]
		private SelectionTransitionSetting m_UpEdgeTransition;

		[SerializeField]
		private SelectionTransitionSetting m_DownEdgeTransition;

		[SerializeField]
		private SelectionTransitionSetting m_RightEdgeTransition;

		[SerializeField]
		private SelectionTransitionSetting m_LeftEdgeTransition;

		[SerializeField]
		private bool m_ScrollAnalogMain;

		[SerializeField]
		private bool m_ScrollAnalogSub;

		[SerializeField]
		private float m_ThresInput;

		public bool isScrollByAnalogMain => false;

		public bool isScrollByAnalogSub => false;

		public float thresInput => 0f;

		public SelectionTransitionSetting GetDirectionSetting(PadInputDirection direction)
		{
			return null;
		}

		public void SetTransitionMode(SelectionItem selectionItem, PadInputDirection direction)
		{
		}
	}
}
