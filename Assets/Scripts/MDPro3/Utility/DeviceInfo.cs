using UnityEngine;

namespace MDPro3.Utility
{
    public static class DeviceInfo
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

        public static bool OnMobile()
        {
#if UNITY_ANDROID
            return true;
#endif
            if (SystemInfo.deviceName == "STEAMDECK")
                return true;
            return false;
        }
    }
}

