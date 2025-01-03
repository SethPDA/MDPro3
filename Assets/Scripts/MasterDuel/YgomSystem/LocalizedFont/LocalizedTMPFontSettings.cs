using TMPro;
using UnityEngine;

namespace YgomSystem.LocalizedFont
{
	//[CreateAssetMenu]
	public class LocalizedTMPFontSettings : LocalizedFontSettings<TMP_FontAsset>
	{
		private const string SETTING_PATH = "ScriptableObjects/LocalizedFont/LocalizedTMPFontSettings";

		private static LocalizedTMPFontSettings s_instance;

		public static LocalizedTMPFontSettings Instance => null;

		protected override string GetFontName(TMP_FontAsset font)
		{
			return null;
		}

		protected override Material GetFontMaterial(TMP_FontAsset font)
		{
			return null;
		}

		public LocalizedTMPFontSettings()
		{
			//((LocalizedFontSettings<>)(object)this)._002Ector();
		}
	}
}
