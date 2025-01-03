using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace YgomSystem.Utility
{
	public static class ClientWork
	{
		private struct UpdateInfo
		{
			public string path;

			public object data;

			//public UpdateInfo(string updatePath, object updateData)
			//{
			//}
		}

		public delegate void NotyfyEventHandler(object v);

		public class notyfyEvent
		{
			public Dictionary<string, notyfyEvent> entry;

			public bool dirty;

			public bool modify;

			public event NotyfyEventHandler handler
			{
				[CompilerGenerated]
				add
				{
				}
				[CompilerGenerated]
				remove
				{
				}
			}

			public void callHandle(Dictionary<string, object> dic)
			{
			}

			public void notyfyDirty(object val)
			{
			}

			public bool isLeaf()
			{
				return false;
			}

			public int getLeafCount()
			{
				return 0;
			}
		}

		private static int s_revision;

		private static Dictionary<string, object> s_data;

		private static notyfyEvent s_notyfy;

		private static SortedDictionary<string, object> s_cache;

		private static List<UpdateInfo> s_keepUpdateList;

		private static List<string> s_keepDeleteList;

		public static void ClearData()
		{
		}

		internal static void dirty(object add, notyfyEvent localnotyfy)
		{
		}

		internal static void dirtyDictionary(Dictionary<string, object> dicadd, notyfyEvent localnotyfy)
		{
		}

		internal static void dirtyList(List<object> listadd, notyfyEvent localnotyfy)
		{
		}

		internal static void marge(object dst, object add)
		{
		}

		internal static void margeDictionary(Dictionary<string, object> dicdst, Dictionary<string, object> dicadd)
		{
		}

		internal static void margeList(List<object> listdst, List<object> listadd)
		{
		}

		internal static notyfyEvent findNotificator(string jsonPath)
		{
			return null;
		}

		internal static T getTypedByJsonPath<T>(string jsonPath, T defaultValue)
		{
			return default(T);
		}

		public static void update(object dict, bool keep = false)
		{
		}

		public static void update(string jsonPath, object dict, bool keep = false)
		{
		}

		public static void updateValue(string jsonPath, object value, bool keep = false)
		{
		}

		public static void updateJson(string jsonString)
		{
		}

		public static void updateJson(string jsonPath, string jsonString)
		{
		}

		public static void updateKeep()
		{
		}

		public static void clearKeep()
		{
		}

		public static void deleteByJsonPath(string jsonPath, bool keep = false)
		{
		}

		public static int getRevision()
		{
			return 0;
		}

		public static object getByJsonPath(string jsonPath)
		{
			return null;
		}

		public static int getIntByJsonPath(string jsonPath, int defaultValue = 0)
		{
			return 0;
		}

		public static long getLongByJsonPath(string jsonPath, long defaultValue = 0L)
		{
			return 0L;
		}

		public static float getFloatByJsonPath(string jsonPath, float defaultValue = 0f)
		{
			return 0f;
		}

		public static string getStringByJsonPath(string jsonPath, string defaultValue = "")
		{
			return null;
		}

		public static bool getBoolByJsonPath(string jsonPath, bool defaultValue = false)
		{
			return false;
		}

		public static Dictionary<string, object> getDictionaryByJsonPath(string jsonPath, Dictionary<string, object> defaultValue = null)
		{
			return null;
		}

		public static List<object> getListByJsonPath(string jsonPath, List<object> defaultValue = null)
		{
			return null;
		}

		public static object getObjectByJsonPath(string jsonPath, object defaultValue = null)
		{
			return null;
		}

		public static object getByJsonPathWithCache(string jsonPath)
		{
			return null;
		}

		public static bool ContainsJsonPath(string jsonPath)
		{
			return false;
		}

		public static void SetNotificator(string jsonPath, NotyfyEventHandler handle)
		{
		}

		public static void ResetNotificator(string jsonPath, NotyfyEventHandler handle)
		{
		}

		public static void DebugDump()
		{
		}

		public static notyfyEvent GetDebugNotyfyEvent(string jsonPath)
		{
			return null;
		}
	}
}
