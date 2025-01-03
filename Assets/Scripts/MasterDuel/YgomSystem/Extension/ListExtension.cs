using System;
using System.Collections.Generic;

namespace YgomSystem.Extension
{
	public static class ListExtension
	{
		public static bool IsNullOrEmpty<T>(this List<T> self)
		{
			return false;
		}

		public static bool IsExists<T>(this List<T> self)
		{
			return false;
		}

		public static int SafeGetCount<T>(this List<T> self)
		{
			return 0;
		}

		public static T GetValueAt<T>(this List<object> list, int index, Func<T, bool> predicator)
		{
			return default(T);
		}

		public static Dictionary<string, object> GetDicAt(this List<object> list, int index)
		{
			return null;
		}

		public static Dictionary<string, object> GetDicOrEmptyAt(this List<object> list, int index)
		{
			return null;
		}
	}
}
