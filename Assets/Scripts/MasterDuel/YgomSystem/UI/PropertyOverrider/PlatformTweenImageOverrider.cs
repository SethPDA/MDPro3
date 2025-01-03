using UnityEngine;
using YgomSystem.Utility;

namespace YgomSystem.UI.PropertyOverrider
{
	public class PlatformTweenImageOverrider : PropertyOverriderBase<TweenImage>
	{
		[SerializeField]
		private TweenImage m_TargetTween;

		[SerializeField]
		private OverrideSpriteArrayProperty m_Frames;

		protected override TweenImage GetTargetComponent()
		{
			return null;
		}

		public override void Import(TweenImage target, DeviceInfo.PlatformType platformType)
		{
		}

		public override void Export(TweenImage target, DeviceInfo.PlatformType platformType)
		{
		}

		public PlatformTweenImageOverrider()
		{
			//((PropertyOverriderBase<>)(object)this)._002Ector();
		}
	}
}
