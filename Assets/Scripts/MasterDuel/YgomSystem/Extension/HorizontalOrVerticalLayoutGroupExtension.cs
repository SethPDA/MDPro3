using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.Extension
{
	public static class HorizontalOrVerticalLayoutGroupExtension
	{
		public static RectOffset GetPaddingWithPlatformOverrider(this HorizontalOrVerticalLayoutGroup lg)
		{
			return null;
		}

		public static float GetSpacingWithPlatformOverrider(this HorizontalOrVerticalLayoutGroup lg)
		{
			return 0f;
		}
	}
}
