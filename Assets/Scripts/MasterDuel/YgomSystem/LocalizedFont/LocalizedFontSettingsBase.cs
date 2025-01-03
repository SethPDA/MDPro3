using UnityEngine;

namespace YgomSystem.LocalizedFont
{
	public abstract class LocalizedFontSettingsBase : ScriptableObject
	{
		public enum Locale
		{
			Other = 0,
			Japanese = 1,
			Korean = 2,
			TraditionalChinese = 3,
			SimplifiedChinese = 4
		}

		public enum FontType
		{
			Other = 0,
			Normal = 1,
			Card = 2,
			Bold = 3,
			Story = 4,
			BigMenu = 5
		}
	}
}
