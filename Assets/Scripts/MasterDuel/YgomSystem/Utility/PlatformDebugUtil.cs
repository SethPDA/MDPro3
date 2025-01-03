namespace YgomSystem.Utility
{
	public static class PlatformDebugUtil
	{
		public const string prefsKeyDebugActive = "PlatformDebug";

		public const string prefsKeyPlatform = "PlatformDebugType";

		public const string prefsKeyDisplayToolbar = "PlatformDebugDisplayToolbar";

		public static bool isPlatformDebugActive => false;

		public static DeviceInfo.Platform debugPlatform => default(DeviceInfo.Platform);

		public static DeviceInfo.PlatformType debugPlatformType => default(DeviceInfo.PlatformType);
	}
}
