using System;
using System.Collections.Generic;
using UnityEngine;

namespace com.adjust.sdk
{
	public class Adjust : MonoBehaviour
	{
		private const string errorMsgEditor = "[Adjust]: SDK can not be used in Editor.";

		private const string errorMsgStart = "[Adjust]: SDK not started. Start it manually using the 'start' method.";

		private const string errorMsgPlatform = "[Adjust]: SDK can only be used in Android, iOS, Windows Phone 8.1, Windows Store or Universal Windows apps.";

		public bool startManually;

		public bool eventBuffering;

		public bool sendInBackground;

		public bool launchDeferredDeeplink;

		public string appToken;

		public AdjustLogLevel logLevel;

		public AdjustEnvironment environment;

		private void Awake()
		{
		}

		private void OnApplicationPause(bool pauseStatus)
		{
		}

		public static void start(AdjustConfig adjustConfig)
		{
		}

		public static void trackEvent(AdjustEvent adjustEvent)
		{
		}

		public static void setEnabled(bool enabled)
		{
		}

		public static bool isEnabled()
		{
			return false;
		}

		public static void setOfflineMode(bool enabled)
		{
		}

		public static void setDeviceToken(string deviceToken)
		{
		}

		public static void gdprForgetMe()
		{
		}

		public static void disableThirdPartySharing()
		{
		}

		public static void appWillOpenUrl(string url)
		{
		}

		public static void sendFirstPackages()
		{
		}

		public static void addSessionPartnerParameter(string key, string value)
		{
		}

		public static void addSessionCallbackParameter(string key, string value)
		{
		}

		public static void removeSessionPartnerParameter(string key)
		{
		}

		public static void removeSessionCallbackParameter(string key)
		{
		}

		public static void resetSessionPartnerParameters()
		{
		}

		public static void resetSessionCallbackParameters()
		{
		}

		public static void trackAdRevenue(string source, string payload)
		{
		}

		public static void trackAppStoreSubscription(AdjustAppStoreSubscription subscription)
		{
		}

		public static void trackPlayStoreSubscription(AdjustPlayStoreSubscription subscription)
		{
		}

		public static void trackThirdPartySharing(AdjustThirdPartySharing thirdPartySharing)
		{
		}

		public static void trackMeasurementConsent(bool measurementConsent)
		{
		}

		public static void requestTrackingAuthorizationWithCompletionHandler(Action<int> statusCallback, string sceneName = "Adjust")
		{
		}

		public static void updateConversionValue(int conversionValue)
		{
		}

		public static int getAppTrackingAuthorizationStatus()
		{
			return 0;
		}

		public static string getAdid()
		{
			return null;
		}

		public static AdjustAttribution getAttribution()
		{
			return null;
		}

		public static string getWinAdid()
		{
			return null;
		}

		public static string getIdfa()
		{
			return null;
		}

		public static string getSdkVersion()
		{
			return null;
		}

		[Obsolete]
		public static void setReferrer(string referrer)
		{
		}

		public static void getGoogleAdId(Action<string> onDeviceIdsRead)
		{
		}

		public static string getAmazonAdId()
		{
			return null;
		}

		private static bool IsEditor()
		{
			return false;
		}

		public static void SetTestOptions(Dictionary<string, string> testOptions)
		{
		}
	}
}
