using System.Collections.Generic;

namespace com.adjust.sdk
{
	public class AdjustUtils
	{
		public static string KeyAdid;

		public static string KeyMessage;

		public static string KeyNetwork;

		public static string KeyAdgroup;

		public static string KeyCampaign;

		public static string KeyCreative;

		public static string KeyWillRetry;

		public static string KeyTimestamp;

		public static string KeyCallbackId;

		public static string KeyEventToken;

		public static string KeyClickLabel;

		public static string KeyTrackerName;

		public static string KeyTrackerToken;

		public static string KeyJsonResponse;

		public static string KeyCostType;

		public static string KeyCostAmount;

		public static string KeyCostCurrency;

		public static string KeyTestOptionsBaseUrl;

		public static string KeyTestOptionsGdprUrl;

		public static string KeyTestOptionsSubscriptionUrl;

		public static string KeyTestOptionsExtraPath;

		public static string KeyTestOptionsBasePath;

		public static string KeyTestOptionsGdprPath;

		public static string KeyTestOptionsDeleteState;

		public static string KeyTestOptionsUseTestConnectionOptions;

		public static string KeyTestOptionsTimerIntervalInMilliseconds;

		public static string KeyTestOptionsTimerStartInMilliseconds;

		public static string KeyTestOptionsSessionIntervalInMilliseconds;

		public static string KeyTestOptionsSubsessionIntervalInMilliseconds;

		public static string KeyTestOptionsTeardown;

		public static string KeyTestOptionsNoBackoffWait;

		public static string KeyTestOptionsiAdFrameworkEnabled;

		public static string KeyTestOptionsAdServicesFrameworkEnabled;

		public static int ConvertLogLevel(AdjustLogLevel? logLevel)
		{
			return 0;
		}

		public static int ConvertBool(bool? value)
		{
			return 0;
		}

		public static double ConvertDouble(double? value)
		{
			return 0.0;
		}

		public static long ConvertLong(long? value)
		{
			return 0L;
		}

		public static string ConvertListToJson(List<string> list)
		{
			return null;
		}

		public static string GetJsonResponseCompact(Dictionary<string, object> dictionary)
		{
			return null;
		}

		public static string GetJsonString(JSONNode node, string key)
		{
			return null;
		}

		public static void WriteJsonResponseDictionary(JSONClass jsonObject, Dictionary<string, object> output)
		{
		}

		public static string TryGetValue(Dictionary<string, string> dictionary, string key)
		{
			return null;
		}
	}
}
