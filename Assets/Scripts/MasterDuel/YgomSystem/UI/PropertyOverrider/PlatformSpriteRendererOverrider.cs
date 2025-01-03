using UnityEngine;
using YgomSystem.Utility;

namespace YgomSystem.UI.PropertyOverrider
{
	public class PlatformSpriteRendererOverrider : PropertyOverriderBase<SpriteRenderer>
	{
		[SerializeField]
		private OverrideSpriteProperty m_Sprite;

		public OverrideSpriteProperty sprite => null;

		public override void Import(SpriteRenderer target, DeviceInfo.PlatformType platformType)
		{
		}

		public override void Export(SpriteRenderer target, DeviceInfo.PlatformType platformType)
		{
		}

		public PlatformSpriteRendererOverrider()
		{
			//((PropertyOverriderBase<>)(object)this)._002Ector();
		}
	}
}
