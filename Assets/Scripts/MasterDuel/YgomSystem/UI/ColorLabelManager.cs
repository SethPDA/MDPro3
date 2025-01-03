using System.Collections.Generic;
using UnityEngine;

namespace YgomSystem.UI
{
	public static class ColorLabelManager
	{
		private static readonly string assetPath;

		private static ColorLabelSetting s_setting;

		private static Dictionary<string, ColorLabel> s_labelStrToEnumMap;

		private static bool s_initalized;

		static ColorLabelManager()
		{
		}

		public static void Setup()
		{
		}

		public static Color GetColor(string label)
		{
			return default(Color);
		}

		public static bool TryGetColor(string label, out Color result)
		{
			result = default(Color);
			return false;
		}

		public static Color GetColor(ColorLabel label)
		{
			return default(Color);
		}

		public static ColorLabel LabelStringToEnum(string label)
		{
			return default(ColorLabel);
		}
	}
}
