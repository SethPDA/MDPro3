using UnityEngine;

namespace YgomSystem.LocalizedFont
{
	//[CreateAssetMenu]
	public class LocalizedUIFontSettings : LocalizedFontSettings<Font>
	{
		private const string SETTING_PATH = "ScriptableObjects/LocalizedFont/LocalizedUIFontSettings";

		private static LocalizedUIFontSettings s_instance;

		public static LocalizedUIFontSettings Instance => null;

		protected override string GetFontName(Font font)
		{
			return null;
		}

		public LocalizedUIFontSettings()
		{
			//((LocalizedFontSettings<>)(object)this)._002Ector();
		}
	}
}
