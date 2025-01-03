using System;

namespace com.adjust.sdk
{
	public class AdjustConfig
	{
		public const string AdjustUrlStrategyChina = "china";

		public const string AdjustUrlStrategyIndia = "india";

		public const string AdjustDataResidencyEU = "data-residency-eu";

		public const string AdjustAdRevenueSourceMopub = "mopub";

		public const string AdjustAdRevenueSourceAdmob = "admob";

		public const string AdjustAdRevenueSourceFbNativeAd = "facebook_native_ad";

		public const string AdjustAdRevenueSourceFbAudienceNetwork = "facebook_audience_network";

		public const string AdjustAdRevenueSourceIronsource = "ironsource";

		public const string AdjustAdRevenueSourceFyber = "fyber";

		public const string AdjustAdRevenueSourceAerserv = "aerserv";

		public const string AdjustAdRevenueSourceAppodeal = "appodeal";

		public const string AdjustAdRevenueSourceAdincube = "adincube";

		public const string AdjustAdRevenueSourceFusePowered = "fusepowered";

		public const string AdjustAdRevenueSourceAddaptr = "addapptr";

		public const string AdjustAdRevenueSourceMillenialMediation = "millennial_mediation";

		public const string AdjustAdRevenueSourceFlurry = "flurry";

		public const string AdjustAdRevenueSourceAdmost = "admost";

		public const string AdjustAdRevenueSourceDeltadna = "deltadna";

		public const string AdjustAdRevenueSourceUpsight = "upsight";

		public const string AdjustAdRevenueSourceUnityads = "unityads";

		public const string AdjustAdRevenueSourceAdtoapp = "adtoapp";

		public const string AdjustAdRevenueSourceTapdaq = "tapdaq";

		internal string appToken;

		internal string sceneName;

		internal string userAgent;

		internal string defaultTracker;

		internal string externalDeviceId;

		internal string urlStrategy;

		internal long? info1;

		internal long? info2;

		internal long? info3;

		internal long? info4;

		internal long? secretId;

		internal double? delayStart;

		internal bool? isDeviceKnown;

		internal bool? sendInBackground;

		internal bool? eventBufferingEnabled;

		internal bool? allowSuppressLogLevel;

		internal bool? needsCost;

		internal bool launchDeferredDeeplink;

		internal AdjustLogLevel? logLevel;

		internal AdjustEnvironment environment;

		internal Action<string> deferredDeeplinkDelegate;

		internal Action<AdjustEventSuccess> eventSuccessDelegate;

		internal Action<AdjustEventFailure> eventFailureDelegate;

		internal Action<AdjustSessionSuccess> sessionSuccessDelegate;

		internal Action<AdjustSessionFailure> sessionFailureDelegate;

		internal Action<AdjustAttribution> attributionChangedDelegate;

		internal bool? readImei;

		internal bool? preinstallTrackingEnabled;

		internal string processName;

		internal bool? allowiAdInfoReading;

		internal bool? allowAdServicesInfoReading;

		internal bool? allowIdfaReading;

		internal bool? skAdNetworkHandling;

		internal Action<string> logDelegate;

		public AdjustConfig(string appToken, AdjustEnvironment environment)
		{
		}

		public AdjustConfig(string appToken, AdjustEnvironment environment, bool allowSuppressLogLevel)
		{
		}

		public void setLogLevel(AdjustLogLevel logLevel)
		{
		}

		public void setDefaultTracker(string defaultTracker)
		{
		}

		public void setExternalDeviceId(string externalDeviceId)
		{
		}

		public void setLaunchDeferredDeeplink(bool launchDeferredDeeplink)
		{
		}

		public void setSendInBackground(bool sendInBackground)
		{
		}

		public void setEventBufferingEnabled(bool eventBufferingEnabled)
		{
		}

		public void setNeedsCost(bool needsCost)
		{
		}

		public void setDelayStart(double delayStart)
		{
		}

		public void setUserAgent(string userAgent)
		{
		}

		public void setIsDeviceKnown(bool isDeviceKnown)
		{
		}

		public void setUrlStrategy(string urlStrategy)
		{
		}

		public void deactivateSKAdNetworkHandling()
		{
		}

		public void setDeferredDeeplinkDelegate(Action<string> deferredDeeplinkDelegate, string sceneName = "Adjust")
		{
		}

		public Action<string> getDeferredDeeplinkDelegate()
		{
			return null;
		}

		public void setAttributionChangedDelegate(Action<AdjustAttribution> attributionChangedDelegate, string sceneName = "Adjust")
		{
		}

		public Action<AdjustAttribution> getAttributionChangedDelegate()
		{
			return null;
		}

		public void setEventSuccessDelegate(Action<AdjustEventSuccess> eventSuccessDelegate, string sceneName = "Adjust")
		{
		}

		public Action<AdjustEventSuccess> getEventSuccessDelegate()
		{
			return null;
		}

		public void setEventFailureDelegate(Action<AdjustEventFailure> eventFailureDelegate, string sceneName = "Adjust")
		{
		}

		public Action<AdjustEventFailure> getEventFailureDelegate()
		{
			return null;
		}

		public void setSessionSuccessDelegate(Action<AdjustSessionSuccess> sessionSuccessDelegate, string sceneName = "Adjust")
		{
		}

		public Action<AdjustSessionSuccess> getSessionSuccessDelegate()
		{
			return null;
		}

		public void setSessionFailureDelegate(Action<AdjustSessionFailure> sessionFailureDelegate, string sceneName = "Adjust")
		{
		}

		public Action<AdjustSessionFailure> getSessionFailureDelegate()
		{
			return null;
		}

		public void setAppSecret(long secretId, long info1, long info2, long info3, long info4)
		{
		}

		public void setAllowiAdInfoReading(bool allowiAdInfoReading)
		{
		}

		public void setAllowAdServicesInfoReading(bool allowAdServicesInfoReading)
		{
		}

		public void setAllowIdfaReading(bool allowIdfaReading)
		{
		}

		public void setProcessName(string processName)
		{
		}

		[Obsolete]
		public void setReadMobileEquipmentIdentity(bool readMobileEquipmentIdentity)
		{
		}

		public void setPreinstallTrackingEnabled(bool preinstallTrackingEnabled)
		{
		}

		public void setLogDelegate(Action<string> logDelegate)
		{
		}
	}
}
