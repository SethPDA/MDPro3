using System;

namespace YgomSystem.Utility
{
	public abstract class DeviceInfo
	{
		public enum Platform
		{
			Unknown = 0,
			PS4 = 1,
			PS5 = 2,
			XboxOne = 3,
			XboxSeriesX = 4,
			Switch = 5,
			Android = 6,
			iOS = 7,
			PC = 8,
			Stadia = 9
		}

		public enum PlatformType
		{
			Unknown = 0,
			Console = 1,
			Mobile = 2,
			PC = 3
		}

		public enum ResourceType
		{
			Unknown = 0,
			HighEnd_HD = 1,
			HighEnd = 2,
			LowEnd = 3
		}

		private static string version;

		private static string model;

		private static string platform;

		private static string dateFormat;

		private static DeviceInfo s_Instance;

		private static int topMargin;

		public static bool IsInitialized => false;

		public static bool isXboxView => false;

		public static bool isTargetPlatformPlayerView => false;

		public static Platform viewPlatform => default(Platform);

		public static PlatformType viewPlatformType => default(PlatformType);

		public static ResourceType resourceType => default(ResourceType);

		private static DeviceInfo GetInstance()
		{
			return null;
		}

		private static DeviceInfo CreateInstance()
		{
			return null;
		}

		public static void Initialize()
		{
		}

		public virtual void initialize()
		{
		}

		public static string GetAppVersion()
		{
			return null;
		}

		protected virtual string getAppVersion()
		{
			return null;
		}

		public static string GetLanguage()
		{
			return null;
		}

		public abstract string getLanguage();

		public static string GetRegion()
		{
			return null;
		}

		public abstract string getRegion();

		public static string GetOSVersion()
		{
			return null;
		}

		public abstract string getOSVersion();

		public static string GetModelName()
		{
			return null;
		}

		public abstract string getModelName();

		public static string GetTimeZone()
		{
			return null;
		}

		public abstract string getTimeZone();

		public static string GetPlatform()
		{
			return null;
		}

		public abstract string getPlatform();

		public static Platform GetViewPlatform()
		{
			return default(Platform);
		}

		public abstract Platform getViewPlatform();

		public static PlatformType GetViewPlatformType()
		{
			return default(PlatformType);
		}

		public abstract PlatformType getViewPlatformType();

		public static ResourceType GetResourceType()
		{
			return default(ResourceType);
		}

		public abstract ResourceType getResourceType();

		public static string GetStartupUrl()
		{
			return null;
		}

		public abstract string getStartupUrl();

		public static void ClearStartupUrl()
		{
		}

		public abstract void clearStartupUrl();

		public static string GetIDFA()
		{
			return null;
		}

		public abstract string getIDFA();

		public static string GetDeviceHash()
		{
			return null;
		}

		public abstract string getDeviceHash();

		public static string GetDateFormat()
		{
			return null;
		}

		public abstract string getDateFormat();

		[Obsolete]
		public static int GetSafeAreaTopMargin()
		{
			return 0;
		}

		public abstract int getSafeAreaTopMargin();

		[Obsolete]
		public static int GetSafeAreaBottomMargin()
		{
			return 0;
		}

		public abstract int getSafeAreaBottomMargin();

		public static bool IsOverAspect()
		{
			return false;
		}

		public static string GetPlatformUserName()
		{
			return null;
		}

		protected virtual string getPlatformUserName()
		{
			return null;
		}
	}
}
