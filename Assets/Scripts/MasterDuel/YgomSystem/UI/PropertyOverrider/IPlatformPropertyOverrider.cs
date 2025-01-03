using YgomSystem.Utility;

namespace YgomSystem.UI.PropertyOverrider
{
	public interface IPlatformPropertyOverrider
	{
		OverrideMode overrideMode { get; set; }

		void ApplyImmediate();

		void ApplyImmediate(DeviceInfo.PlatformType platformType);

		void Import();

		void Import(DeviceInfo.PlatformType platformType);

		void Export();

		void Export(DeviceInfo.PlatformType platformType);
	}
}
