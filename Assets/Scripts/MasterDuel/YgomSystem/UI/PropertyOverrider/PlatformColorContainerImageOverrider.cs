using UnityEngine;
using YgomSystem.Utility;

namespace YgomSystem.UI.PropertyOverrider
{
	public class PlatformColorContainerImageOverrider : PropertyOverriderBase<ColorContainerImage>
	{
		[SerializeField]
		public int colorContainerIndex;

		[SerializeField]
		private OverrideSpriteProperty m_SpriteUnselected;

		[SerializeField]
		private OverrideSpriteProperty m_SpriteSelected;

		[SerializeField]
		private OverrideSpriteProperty m_SpriteButtonDown;

		[SerializeField]
		private OverrideSpriteProperty m_SpriteButtonEnter;

		[SerializeField]
		private OverrideSpriteProperty m_SpriteInactive;

		public OverrideSpriteProperty spriteUnselected => null;

		public OverrideSpriteProperty spriteSelected => null;

		public OverrideSpriteProperty spriteButtonDown => null;

		public OverrideSpriteProperty spriteButtonEnter => null;

		public OverrideSpriteProperty spriteInactive => null;

		protected override ColorContainerImage GetTargetComponent()
		{
			return null;
		}

		public override void Import(ColorContainerImage target, DeviceInfo.PlatformType platformType)
		{
		}

		public override void Export(ColorContainerImage target, DeviceInfo.PlatformType platformType)
		{
		}

		public PlatformColorContainerImageOverrider()
		{
			//((PropertyOverriderBase<>)(object)this)._002Ector();
		}
	}
}
