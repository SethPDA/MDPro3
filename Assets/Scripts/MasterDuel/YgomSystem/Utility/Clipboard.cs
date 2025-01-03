using System.Reflection;

namespace YgomSystem.Utility
{
	public class Clipboard
	{
		private static PropertyInfo systemCopyBufferProperty;

		public static bool support => false;

		private static PropertyInfo GetSystemCopyBufferProperty()
		{
			return null;
		}

		public static void SetText(string text)
		{
		}
	}
}
