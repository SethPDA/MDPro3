using System.Collections.Generic;
using System.Globalization;

namespace YgomSystem.Utility
{
	public class Locale
	{
		public const string Japanese = "ja-JP";

		public const string English = "en-US";

		public const string French = "fr-FR";

		public const string Italian = "it-IT";

		public const string German = "de-DE";

		public const string Spanish = "es-ES";

		public const string Portuguese = "pt-BR";

		public const string Korean = "ko-KR";

		public const string TCH = "zh-TW";

		public const string SCH = "zh-CN";

		public const string DefaultLanguage = "en-US";

		private const string DefaultLanguageName = "English";

		private static string language;

		private static CultureInfo cultureInfo;

		private static List<string> supportedLanguages;

		private static List<string> supportedReadableLanguages;

		private static List<string> supportedVoices;

		private static List<string> supportedReadableVoices;

		private static string normalizeLanguage(string lang, bool useDefault)
		{
			return null;
		}

		private static void setupLang(List<object> langs, List<string> languages, List<string> readables)
		{
		}

		private static void setup()
		{
		}

		public static List<string> GetSupportedLanguages()
		{
			return null;
		}

		public static bool IsSupportedLanguage(string lang)
		{
			return false;
		}

		public static List<string> GetSupportedVoices()
		{
			return null;
		}

		public static void SetLanguage(string lang)
		{
		}

		public static void SetInitLanguage(string lang)
		{
		}

		public static string GetVoice()
		{
			return null;
		}

		public static string GetLanguage()
		{
			return null;
		}

		public static CultureInfo GetCultureInfo()
		{
			return null;
		}

		public static string GetReadableLanguage(string lang)
		{
			return null;
		}

		public static List<string> GetReadableLanguages()
		{
			return null;
		}

		public static string GetCurrentReadableLanguage()
		{
			return null;
		}

		public static List<string> GetReadableVoices()
		{
			return null;
		}

		public static string GetReadableVoice(string lang)
		{
			return null;
		}

		public static bool EnableVoices()
		{
			return false;
		}
	}
}
