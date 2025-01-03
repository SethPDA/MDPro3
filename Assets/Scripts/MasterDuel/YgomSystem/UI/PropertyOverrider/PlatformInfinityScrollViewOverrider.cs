using UnityEngine;
using YgomSystem.UI.InfinityScroll;
using YgomSystem.Utility;

namespace YgomSystem.UI.PropertyOverrider
{
	public class PlatformInfinityScrollViewOverrider : PropertyOverriderBase<InfinityScrollView>
	{
		[SerializeField]
		private OverrideStringProperty m_ELabelTemplate;

		public override void Import(InfinityScrollView target, DeviceInfo.PlatformType platformType)
		{
		}

		public override void Export(InfinityScrollView target, DeviceInfo.PlatformType platformType)
		{
		}

		public PlatformInfinityScrollViewOverrider()
		{
			//((PropertyOverriderBase<>)(object)this)._002Ector();
		}
	}
}
