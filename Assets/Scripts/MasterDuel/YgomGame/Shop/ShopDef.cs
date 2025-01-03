namespace YgomGame.Shop
{
	public static class ShopDef
	{
		public enum ProductType
		{
			Pack = 1,
			Structure = 2,
			Accessories = 3,
			Duelpass = 4,
			Card = 5,
			Prize = 6
		}

		public enum ShowcaseCategory
		{
			Pickup = 5,
			Pack = 1,
			Structure = 2,
			Accessory = 3,
			Special = 4
		}

		public enum PackSubCategory
		{
			Normal = 1,
			Secret = 2,
			Bonus = 3
		}

		public enum SpecialSubCategory
		{
			DuelPass = 1,
			Set = 2,
			DeckLimit = 3
		}

		public enum HighlightType
		{
			CardThumb = 1,
			WideThumb = 3
		}

		public enum ListButtonType
		{
			Default = 0,
			Highlight = 1
		}

		public enum ViewerLoopType
		{
			Default = 0,
			None = 1
		}

		internal const string k_SettingKey_LimitAlertSec = "limitAlertSec";

		internal const string k_SettingKey_HighlightStyleType = "highlightStyleType";

		internal const string k_SettingKey_ProductWidgetLabel = "productWidget";

		internal const string k_SettingKey_HeadLabelText = "headLabelText";

		internal const string k_SettingKey_SkipSoldoutSort = "skipSoldoutSort";

		internal const string k_SettingKey_IsShortPayAmountSort = "isShortPayAmountSort";

		internal const string k_SettingKey_IgnoreTurnoffBadge = "ignoreTurnoffBadge";

		internal const string k_SettingKey_BgId = "bgId";

		internal const string k_SettingKey_ListDesc = "listDesc";

		internal const string k_SettingKey_InformButtonLabel = "informButton";

		internal const string k_SettingKey_HighlightType = "HighlightType";

		internal const string k_SettingKey_ProductSubLabel = "productSubLabel";

		internal const string k_SettingKey_ViewerLoopType = "viewerLoopType";

		internal const string k_SettingKey_HideSummonPlay = "hideSummonPlay";
	}
}
