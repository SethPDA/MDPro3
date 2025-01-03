using UnityEngine;
using YgomSystem.Utility;

namespace YgomSystem.UI.PropertyOverrider
{
	public class PlatformRectTransformScaleOverrider : PropertyOverriderBase<RectTransform>
	{
		[SerializeField]
		private OverrideVector3Property m_Scale;

		public override void Import(RectTransform target, DeviceInfo.PlatformType platformType)
		{
		}

		public override void Export(RectTransform target, DeviceInfo.PlatformType platformType)
		{
		}

		public PlatformRectTransformScaleOverrider()
		{
			//((PropertyOverriderBase<>)(object)this)._002Ector();
		}
	}
}
