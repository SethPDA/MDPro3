using YgomSystem.Utility;

namespace YgomSystem.UI
{
	public class PlatformVisibleIcon : PlatformVisibleIconBase
	{
		[EnumFlags]
		public DeviceInfo.Platform platformFlags;

		[EnumFlags]
		public SelectorManager.InputDevice inputDeviceFlags;

		protected override bool IsDispPlatform()
		{
			return false;
		}
	}
}
