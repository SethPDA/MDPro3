namespace YgomSystem.LocalizedFont
{
	public interface ILocalizedFontOwner
	{
		LocalizedFontSettingsBase.FontType localizedFontType { get; set; }

		int localizedFontMaterialIndex { get; set; }
	}
}
