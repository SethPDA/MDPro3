using System.Collections.Generic;

namespace YgomSystem.Extension
{
	public static class IReadOnlyCollectionExtension
	{
		public static bool IsNullOrEmpty<T>(this IReadOnlyCollection<T> self)
		{
			return false;
		}

		public static bool IsExists<T>(this IReadOnlyCollection<T> self)
		{
			return false;
		}

		public static int SafeGetCount<T>(this IReadOnlyCollection<T> self)
		{
			return 0;
		}
	}
}
