using System.Collections.Generic;
using System.Text;

namespace YgomSystem.Utility
{
	public class RichTextExtension
	{
		public delegate string replaceMarkup(ref string data, string value, string tag, Dictionary<string, string> param);

		public static string[] UguiSupportedTags;

		private static Dictionary<string, replaceMarkup> registTag;

		private static bool IsSupportedTag(string tag, string[] supportedTags)
		{
			return false;
		}

		private static void StartTags(StringBuilder outstr, List<KeyValuePair<string, string>> tagstack)
		{
		}

		private static void EndTags(StringBuilder outstr, List<KeyValuePair<string, string>> tagstack)
		{
		}

		public static string Substring(string text, int startIndex, int length, string[] supportedTags)
		{
			return null;
		}

		public static string RemoveMarkup(string text, string[] supportedTags)
		{
			return null;
		}

		private static string GetInnermark(string text, int startIndex, int endIndex)
		{
			return null;
		}

		private static string RemoveInnermarkEndToken(string innermark)
		{
			return null;
		}

		private static string GetTag(string innermark)
		{
			return null;
		}

		public static int Length(string text, string[] supportedTags)
		{
			return 0;
		}

		private static string xmlDecode(string src)
		{
			return null;
		}

		private static string xmlEncode(string src)
		{
			return null;
		}

		private static void passSpace(string param, ref int i)
		{
		}

		private static string getId(string param, ref int i)
		{
			return null;
		}

		private static string getValue(string param, ref int i)
		{
			return null;
		}

		private static Dictionary<string, string> GetParams(string param)
		{
			return null;
		}

		public static void AddMarkupTag(string tag, replaceMarkup func)
		{
		}

		public static string ProcessMarkup(string text)
		{
			return null;
		}
	}
}
