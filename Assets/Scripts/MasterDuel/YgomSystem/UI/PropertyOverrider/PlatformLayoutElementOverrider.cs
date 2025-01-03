using UnityEngine;
using UnityEngine.UI;
using YgomSystem.Utility;

namespace YgomSystem.UI.PropertyOverrider
{
	public class PlatformLayoutElementOverrider : PropertyOverriderBase<LayoutElement>
	{
		[SerializeField]
		private OverrideBoolProperty m_IgnoreLayout;

		[SerializeField]
		private OverrideFloatProperty m_MinWidth;

		[SerializeField]
		private OverrideFloatProperty m_MinHeight;

		[SerializeField]
		private OverrideFloatProperty m_PreferredWidth;

		[SerializeField]
		private OverrideFloatProperty m_PreferredHeight;

		[SerializeField]
		private OverrideFloatProperty m_FlexibleWidth;

		[SerializeField]
		private OverrideFloatProperty m_FlexibleHeight;

		[SerializeField]
		private OverrideIntProperty m_LayoutPriority;

		public override void Import(LayoutElement target, DeviceInfo.PlatformType platformType)
		{
		}

		public override void Export(LayoutElement target, DeviceInfo.PlatformType platformType)
		{
		}

		public PlatformLayoutElementOverrider()
		{
			//((PropertyOverriderBase<>)(object)this)._002Ector();
		}
	}
}
