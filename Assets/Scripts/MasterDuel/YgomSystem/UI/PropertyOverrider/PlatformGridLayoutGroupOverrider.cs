using UnityEngine;
using UnityEngine.UI;
using YgomSystem.Utility;

namespace YgomSystem.UI.PropertyOverrider
{
	public class PlatformGridLayoutGroupOverrider : PropertyOverriderBase<GridLayoutGroup>
	{
		[SerializeField]
		private OverrideRectOffsetProperty m_Padding;

		[SerializeField]
		private OverrideTextAnchorProperty m_ChildAlignment;

		[SerializeField]
		private OverrideGridLayoutGroupCornerProperty m_StartCorner;

		[SerializeField]
		private OverrideGridLayoutGroupAxisProperty m_StartAxis;

		[SerializeField]
		private OverrideVector2Property m_CellSize;

		[SerializeField]
		private OverrideVector2Property m_Spacing;

		[SerializeField]
		private OverrideGridLayoutGroupConstraintProperty m_Constraint;

		[SerializeField]
		private OverrideIntProperty m_ConstraintCount;

		public OverrideRectOffsetProperty padding => null;

		public OverrideIntProperty constraintCount => null;

		public override void Import(GridLayoutGroup target, DeviceInfo.PlatformType platformType)
		{
		}

		public override void Export(GridLayoutGroup target, DeviceInfo.PlatformType platformType)
		{
		}

		public PlatformGridLayoutGroupOverrider()
		{
			//((PropertyOverriderBase<>)(object)this)._002Ector();
		}
	}
}
