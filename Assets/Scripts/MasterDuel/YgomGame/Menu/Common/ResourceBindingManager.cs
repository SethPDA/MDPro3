using UnityEngine;

namespace YgomGame.Menu.Common
{
	public static class ResourceBindingManager
	{
		public static readonly CardResourceBinder cardBinder;

		public static readonly RarityIconBinder rarityIconBinder;

		public static readonly CraftIconBinder craftIconBinder;

		public static readonly OutGameBGResourceBinder outGameBGBinder;

		public static readonly ShopResourceBinder shopResourceBinder;

		public static readonly CardPackResourceBinder cardPackBinder;

		public static readonly SoloResourceBinder soloResourceBinder;

		public static readonly ConsumeItemBinder consumeBinder;

		public static readonly DeckResourceBinder deckBinder;

		public static readonly RegulationIconBinder regulationIconBinder;

		public static readonly PlayerIconResourceBinder playerIconBinder;

		public static readonly AvatarResourceBinder avatarBinder;

		public static readonly ProfileResourceBinder profileBinder;

		public static readonly WallPaperResourceBinder wallPaperBinder;

		public static readonly FieldResourceBinder fieldBinder;

		public static readonly EventLogoResourceBinder eventLogoBinder;

		public static readonly RegulationLogoResourceBinder regulationLogoBinder;

		internal const string deluxebadgePath = "Prefabs/Profile/DeluxeBadge/DeluxeBadge";

		internal const string deluxebadgePath2 = "Prefabs/Profile/DeluxeBadge/DeluxeBadge2";

		internal const string deluxebadgePath2_L = "Prefabs/Profile/DeluxeBadge/DeluxeBadge2_L";

		public static void Initialize()
		{
		}

		public static BindingItemThumb BindingItemThumb(GameObject target, bool isPeriod, int itemCategory, int itemId, bool isLarge = false, BindingItemThumb.DxBadgeMode dxBadgeMode = YgomGame.Menu.Common.BindingItemThumb.DxBadgeMode.None)
		{
			return null;
		}

		public static Component BindingItemThumbContent(GameObject target, bool isPeriod, int itemCategory, int itemId)
		{
			return null;
		}

		public static Component BindingItemThumbLargeContent(GameObject target, bool isPeriod, int itemCategory, int itemId)
		{
			return null;
		}

		private static Component DummyBindingThumb(GameObject target, int itemId)
		{
			return null;
		}
	}
}
