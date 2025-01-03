using System;
using System.Collections.Generic;
using UnityEngine;

namespace YgomSystem.LocalizedFont
{
	public abstract class LocalizedFontSettings<T_FONT> : LocalizedFontSettingsBase where T_FONT : UnityEngine.Object
	{
		[Serializable]
		public class LocalizedFontMaterialEntry
		{
			public string path;

			public string name;
		}

		[Serializable]
		public class LocalizedFontLocaleEntry
		{
			public Locale locale;

			public string fontPath;

			public string fontName;

			public LocalizedFontMaterialEntry[] materials;
		}

		[Serializable]
		public class LocalizedFontEntry
		{
			public FontType fontType;

			public LocalizedFontLocaleEntry[] locales;
		}

		private class LoadedFontEntry
		{
			public string fontPath;

			public T_FONT font;

			public Material defaultMaterial;

			public Material[] materials;
		}

		[SerializeField]
		private LocalizedFontEntry[] localizedFonts;

		private Dictionary<FontType, LoadedFontEntry> m_loadedFonts;

		private bool m_localeInitialized;

		private Locale m_localeCache;

		public bool raiseErrorOnLoadImmediateFont;

		private Locale m_oldLocale;

		private Dictionary<FontType, LocalizedFontLocaleEntry> m_otherFonts;

		private Dictionary<string, LoadedFontEntry> m_fontCache;

		public LocalizedFontLocaleEntry GetLocalizedFontLocaleEntry(FontType fontType, Locale locale)
		{
			return null;
		}

		public (FontType, LocalizedFontLocaleEntry) GetEntryFromOtherFontName(string otherFontName)
		{
			return default((FontType, LocalizedFontLocaleEntry));
		}

		public FontType GetFontTypeFromOtherFontName(string otherFontName)
		{
			return default(FontType);
		}

		public void UpdateLocaleCache()
		{
		}

		public Locale GetCurrentLocale(bool updateCache = true)
		{
			return default(Locale);
		}

		private Material _getFontMaterial(FontType fontType, LoadedFontEntry lfe, Material mat)
		{
			return null;
		}

		public (T_FONT, Material) GetLocalized(FontType fontType, int materialIndex, Locale locale)
		{
			return default((T_FONT, Material));
		}

		public (T_FONT, Material) GetLocalized(FontType fontType, int materialIndex)
		{
			return default((T_FONT, Material));
		}

		public T_FONT GetLocalizedFont(FontType fontType, Locale locale)
		{
			return null;
		}

		public T_FONT GetLocalizedFont(FontType fontType)
		{
			return null;
		}

		public void LoadFonts()
		{
		}

		public bool IsFontsLoaded()
		{
			return false;
		}

		private LoadedFontEntry _getLocalizedFontEntry(FontType fontType, LocalizedFontLocaleEntry lfle)
		{
			return null;
		}

		public (T_FONT, Material) ToLocalized(T_FONT font, Material mat)
		{
			return default((T_FONT, Material));
		}

		public T_FONT ToLocalizedFont(T_FONT font)
		{
			return null;
		}

		public void ClearFontCache()
		{
		}

		protected abstract string GetFontName(T_FONT font);

		protected virtual Material GetFontMaterial(T_FONT font)
		{
			return null;
		}
	}
}
