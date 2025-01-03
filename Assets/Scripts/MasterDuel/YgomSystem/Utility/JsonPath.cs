using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

namespace YgomSystem.Utility
{
	public static class JsonPath
	{
		private static Regex makupRegex;

		private const string onetab = "\t";

		private static char[] strescape;

		private const string yamltab = "  ";

		private static string procForm(string jsonPath, object scan)
		{
			return null;
		}

		public static List<string> parth(string jsonPath, object scan)
		{
			return null;
		}

		public static object get(object scan, string jsonPath, out object lastparent, out string lastkey)
		{
			lastparent = null;
			lastkey = null;
			return null;
		}

		public static object get(object scan, string jsonPath)
		{
			return null;
		}

		public static bool set(object dst, string jsonPath, object value)
		{
			return false;
		}

		public static bool contains(object scan, string jsonPath)
		{
			return false;
		}

		public static bool getBool(object scan, string jsonPath, bool defaultValue = false)
		{
			return false;
		}

		public static int getInt(object scan, string jsonPath, int defaultValue = 0)
		{
			return 0;
		}

		public static long getLong(object scan, string jsonPath, long defaultValue = 0L)
		{
			return 0L;
		}

		public static float getFloat(object scan, string jsonPath, float defaultValue = 0f)
		{
			return 0f;
		}

		public static string getString(object scan, string jsonPath, string defaultValue = "")
		{
			return null;
		}

		public static T getEnum<T>(object scan, string jsonPath, T defaultValue)
		{
			return default(T);
		}

		public static Dictionary<string, object> getDictionary(object scan, string jsonPath, Dictionary<string, object> defaultValue = null)
		{
			return null;
		}

		public static List<object> getList(object scan, string jsonPath, List<object> defaultValue = null)
		{
			return null;
		}

		public static Vector2 getVector2(object scan, string jsonPath, Vector2 defalutValie)
		{
			return default(Vector2);
		}

		public static Vector3 getVector3(object scan, string jsonPath, Vector3 defalutValie)
		{
			return default(Vector3);
		}

		public static Vector4 getVector4(object scan, string jsonPath, Vector4 defalutValie)
		{
			return default(Vector4);
		}

		internal static T getTyped<T>(object scan, string jsonPath, T defaultValue)
		{
			return default(T);
		}

		public static bool objectToBool(object i, bool defaultValue = false)
		{
			return false;
		}

		public static float objectToFloat(object i, float defaultValue = 0f)
		{
			return 0f;
		}

		public static int objectToInt(object i, int detaultValue = 0)
		{
			return 0;
		}

		public static string objectToString(object i, string detaultValue = null)
		{
			return null;
		}

		public static long objectToLong(object i, long defaultValue = 0L)
		{
			return 0L;
		}

		public static Vector2 objectToVector2(object scan, Vector2 defalutValie)
		{
			return default(Vector2);
		}

		public static Vector3 objectToVector3(object scan, Vector3 defalutValie)
		{
			return default(Vector3);
		}

		public static Vector4 objectToVector4(object scan, Vector4 defalutValie)
		{
			return default(Vector4);
		}

		public static Color objectToColor(object c, Color degalutValue)
		{
			return default(Color);
		}

		public static List<string> objectToStringList(object obj)
		{
			return null;
		}

		private static string jsonString(string str)
		{
			return null;
		}

		public static string objectToJson(object obj)
		{
			return null;
		}

		public static string objectToFormatJson(object obj, int tabdepth = 0)
		{
			return null;
		}

		public static string objectToFormatJsonFistComma(object obj, int tabdepth = 0)
		{
			return null;
		}

		public static string objectToYaml(object obj, int tabdepth = 0)
		{
			return null;
		}

		public static object copyObject(object src)
		{
			return null;
		}

		public static void margeList(List<object> dst, List<object> src)
		{
		}

		public static void margeDictionary(Dictionary<string, object> dst, Dictionary<string, object> src)
		{
		}

		public static void margeDictionaryWithAlias(Dictionary<string, object> dst, Dictionary<string, object> src, Dictionary<string, object> alias)
		{
		}

		public static Dictionary<string, object> joinDictionary(Dictionary<string, object> dic1, Dictionary<string, object> dic2)
		{
			return null;
		}
	}
}
