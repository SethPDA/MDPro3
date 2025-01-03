using UnityEngine;
using UnityEngine.UI;
using YgomSystem.Utility;

namespace YgomSystem.UI.PropertyOverrider
{
	public class PlatformImageOverrider : PropertyOverriderBase<Image>
	{
		[SerializeField]
		private OverrideSpriteProperty m_SourceImage;

		[SerializeField]
		private OverrideMaterialProperty m_Material;

		public OverrideSpriteProperty sprite => null;

		public OverrideMaterialProperty material => null;

		public override void Import(Image target, DeviceInfo.PlatformType platformType)
		{
		}

		public override void Export(Image target, DeviceInfo.PlatformType platformType)
		{
		}

		public PlatformImageOverrider()
		{
			//((PropertyOverriderBase<>)(object)this)._002Ector();
		}
	}
}
