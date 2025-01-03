using System;
using YgomSystem.Utility;

namespace YgomSystem.UI.PropertyOverrider
{
	[Serializable]
	public class OverridePropertyBase<T>
	{
		public T m_DefaultValue;

		public T m_MobileValue;

		public T GetPlatformValue()
		{
			return default(T);
		}

		public T GetPlatformValue(DeviceInfo.PlatformType platformType)
		{
			return default(T);
		}

		public void SetPlatformValue(DeviceInfo.PlatformType platformType, T value)
		{
		}
	}
}
