using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace YgomSystem.Utility
{
	public sealed class TextData
	{
		internal class TextGroup
		{
			private int refCount;

			private string type;

			private string resourcePath;

			private Dictionary<string, string> texts;

			private bool scrambling;

			private bool m_isDone;

			private bool m_isError;

			private static Regex reg;

			private int SaftyRecursiveCheck;

			internal string getResourcePath(string typename)
			{
				return null;
			}

			public TextGroup(string tp, bool async = false)
			{
			}

			public TextGroup(Type tp, bool async = false)
			{
			}

			public void Reload()
			{
			}

			public void addRef()
			{
			}

			public bool delRef()
			{
				return false;
			}

			public int getRef()
			{
				return 0;
			}

			public bool isDone()
			{
				return false;
			}

			public bool isError()
			{
				return false;
			}

			private void LoadRequestCompleteHandler(string path)
			{
			}

			private void initProc()
			{
			}

			public bool ContainsText(string name)
			{
				return false;
			}

			public string GetText(string name, bool richTextEx)
			{
				return null;
			}
		}

		private static string s_lang;

		private static Dictionary<string, TextGroup> s_text;

		private static Dictionary<string, string> s_replace;

		public static void Load<T>()
		{
		}

		public static void LoadAsync<T>()
		{
		}

		public static void Load(string groupid)
		{
		}

		public static void LoadAsync(string groupid)
		{
		}

		private static void LoadGroup(string group)
		{
		}

		private static void LoadGroupAsync(string group)
		{
		}

		public static void Unload<T>()
		{
		}

		public static void Unload(string groupid)
		{
		}

		private static void UnloadGroup(string group)
		{
		}

		public static void Reload()
		{
		}

		public static void Reload<T>()
		{
		}

		private static void ReloadGroup(string group)
		{
		}

		public static bool IsLoad<T>()
		{
			return false;
		}

		public static bool IsLoad(string groupid)
		{
			return false;
		}

		public static bool IsDone<T>()
		{
			return false;
		}

		public static bool IsDoneWithName(string fullTextId)
		{
			return false;
		}

		public static bool IsErrorWithName(string fullTextId)
		{
			return false;
		}

		public static bool IsDoneWithGroup(string groupId)
		{
			return false;
		}

		public static bool IsErrorWithGroup(string groupId)
		{
			return false;
		}

		public static bool IsTextId(string fullTextId)
		{
			return false;
		}

		public static string EnumToFullTextId<T>(T textEnum)
		{
			return null;
		}

		public static bool ParseTextId(string fullTextId, out string groupId, out string textId)
		{
			groupId = null;
			textId = null;
			return false;
		}

		public static string MakeGroupId(string groupId)
		{
			return null;
		}

		public static string MakeTextId(string groupId, string textId)
		{
			return null;
		}

		public static string MakeTextId(string textId)
		{
			return null;
		}

		public static bool ContainsText<T>(T TextEnum)
		{
			return false;
		}

		public static string GetText<T>(T TextEnum, bool richTextEx = false)
		{
			return null;
		}

		public static void SetReplaceText(string label, string text)
		{
		}

		public static string GetReplaceText(string label)
		{
			return null;
		}

		public static void ReloadAllText()
		{
		}

		public static void SetLanguage(string lang, bool forceReload = false)
		{
		}
	}
}
