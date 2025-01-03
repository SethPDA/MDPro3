using UnityEngine;
using UnityEngine.UI;
using YgomSystem.Utility;

namespace YgomSystem.UI.PropertyOverrider
{
	public class PlatformLayoutGroupOverrider : PropertyOverriderBase<HorizontalOrVerticalLayoutGroup>
	{
		[SerializeField]
		private OverrideRectOffsetProperty m_Padding;

		[SerializeField]
		private OverrideTextAnchorProperty m_ChildAlignment;

		[SerializeField]
		private OverrideFloatProperty m_Spacing;

		[SerializeField]
		private OverrideBoolProperty m_ChildForceExpandWidth;

		[SerializeField]
		private OverrideBoolProperty m_ChildForceExpandHeight;

		[SerializeField]
		private OverrideBoolProperty m_ChildControlWidth;

		[SerializeField]
		private OverrideBoolProperty m_ChildControlHeight;

		[SerializeField]
		private OverrideBoolProperty m_ChildScaleWidth;

		[SerializeField]
		private OverrideBoolProperty m_ChildScaleHeight;

		[SerializeField]
		private OverrideBoolProperty m_ReverseArrangement;

		public OverrideRectOffsetProperty padding => null;

		public OverrideFloatProperty spacing => null;

		public OverrideTextAnchorProperty childAlignment => null;

		public override void Import(HorizontalOrVerticalLayoutGroup target, DeviceInfo.PlatformType platformType)
		{
		}

		public override void Export(HorizontalOrVerticalLayoutGroup target, DeviceInfo.PlatformType platformType)
		{
		}

		public PlatformLayoutGroupOverrider()
		{
			//((PropertyOverriderBase<>)(object)this)._002Ector();
		}
	}
}
