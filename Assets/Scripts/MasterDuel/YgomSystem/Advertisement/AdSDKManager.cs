using System;
using System.Runtime.CompilerServices;

namespace YgomSystem.Advertisement
{
	public static class AdSDKManager
	{
		public static bool IsOptout => false;

		public static bool IsEnableDefine => false;

		public static bool IsEnable => false;

		public static bool IsInitialize
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static string AdId => null;

		public static string Idfa => null;

		public static string Idfv => null;

		public static string gpsAdId => null;

		public static void Initialize(Action callback = null)
		{
		}

		public static void UpdateID()
		{
		}

		public static void UpdateAdjustData()
		{
		}

		public static void OptoutNotificator(object o)
		{
		}

		public static bool IsAdRecommendEnable()
		{
			return false;
		}

		public static void OpenAdRecommend()
		{
		}

		public static void SendTrackCreateUserId()
		{
		}

		public static void SendTrackLaunch()
		{
		}

		public static void SendTrackTutorialComp()
		{
		}
	}
}
