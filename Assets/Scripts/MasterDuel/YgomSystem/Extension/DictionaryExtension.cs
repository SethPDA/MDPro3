using System;
using System.Collections.Generic;

namespace YgomSystem.Extension
{
	public static class DictionaryExtension
	{
		public static T GetValue<T>(this Dictionary<string, object> dic, string key, Func<T, bool> predicator)
		{
			return default(T);
		}

		public static T GetValueOrDefault<T>(this Dictionary<string, object> dic, string key, T defaultValue, Func<T, bool> predicator)
		{
			return default(T);
		}

		public static T GetValueOrNull<T>(this Dictionary<string, object> dic, string key, Func<T, bool> predicator) where T : class
		{
			return null;
		}

		public static bool TryGetValue<T>(this Dictionary<string, object> dic, string key, out T value, T defaultValue = default(T))
		{
			value = default(T);
			return false;
		}

		public static bool GetBool(this Dictionary<string, object> dic, string key)
		{
			return false;
		}

		public static bool GetBoolOrDefault(this Dictionary<string, object> dic, string key, bool defaultValue = false)
		{
			return false;
		}

		public static bool TryGetBool(this Dictionary<string, object> dic, string key, out bool value, bool defaultValue = false)
		{
			value = default(bool);
			return false;
		}

		public static long GetLong(this Dictionary<string, object> dic, string key)
		{
			return 0L;
		}

		public static long GetLongOrDefault(this Dictionary<string, object> dic, string key, long defaultValue = 0L)
		{
			return 0L;
		}

		public static bool TryGetLong(this Dictionary<string, object> dic, string key, out long value, long defaultValue = 0L)
		{
			value = default(long);
			return false;
		}

		public static int GetInt(this Dictionary<string, object> dic, string key)
		{
			return 0;
		}

		public static int GetIntOrDefault(this Dictionary<string, object> dic, string key, int defaultValue = 0)
		{
			return 0;
		}

		public static bool TryGetInt(this Dictionary<string, object> dic, string key, out int value, int defaultValue = 0)
		{
			value = default(int);
			return false;
		}

		public static string GetString(this Dictionary<string, object> dic, string key)
		{
			return null;
		}

		public static string GetStringOrEmpty(this Dictionary<string, object> dic, string key)
		{
			return null;
		}

		public static string GetStringOrNull(this Dictionary<string, object> dic, string key)
		{
			return null;
		}

		public static T GetEnum<T>(this Dictionary<string, object> dic, string key) where T : Enum
		{
			return default(T);
		}

		public static T GetEnumOrDefault<T>(this Dictionary<string, object> dic, string key, T defaultValue = default(T)) where T : Enum
		{
			return default(T);
		}

		public static bool TryGetEnum<T>(this Dictionary<string, object> dic, string key, out T value, T defaultValue = default(T)) where T : Enum
		{
			value = default(T);
			return false;
		}

		public static List<object> GetList(this Dictionary<string, object> dic, string key)
		{
			return null;
		}

		public static List<object> GetListOrEmpty(this Dictionary<string, object> dic, string key)
		{
			return null;
		}

		public static List<object> GetListOrNull(this Dictionary<string, object> dic, string key)
		{
			return null;
		}

		public static Dictionary<string, object> GetDic(this Dictionary<string, object> dic, string key)
		{
			return null;
		}

		public static Dictionary<string, object> GetDicOrEmpty(this Dictionary<string, object> dic, string key)
		{
			return null;
		}

		public static Dictionary<string, object> GetDicOrNull(this Dictionary<string, object> dic, string key)
		{
			return null;
		}
	}
}
