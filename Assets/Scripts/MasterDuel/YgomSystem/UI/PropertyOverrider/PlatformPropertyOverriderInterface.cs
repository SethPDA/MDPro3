using UnityEngine;
using YgomSystem.Utility;

namespace YgomSystem.UI.PropertyOverrider
{
	public abstract class PlatformPropertyOverriderInterface : MonoBehaviour, IPlatformPropertyOverrider
	{
		public abstract OverrideMode overrideMode { get; set; }

		public abstract void ApplyImmediate();

		public abstract void ApplyImmediate(DeviceInfo.PlatformType platformType);

		public abstract void Export();

		public abstract void Export(DeviceInfo.PlatformType platformType);

		public abstract void Import();

		public abstract void Import(DeviceInfo.PlatformType platformType);
	}
}
