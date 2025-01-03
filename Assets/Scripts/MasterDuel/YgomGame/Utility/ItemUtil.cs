using System;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.Dialog.CommonDialog;
using YgomGame.Menu.Common;

namespace YgomGame.Utility
{
	public class ItemUtil
	{
		public enum Category
		{
			NONE = 0,
			CONSUME = 1,
			CARD = 2,
			AVATAR = 3,
			ICON = 4,
			PROFILE_TAG = 5,
			ICON_FRAME = 6,
			PROTECTOR = 7,
			DECK_CASE = 8,
			FIELD = 9,
			FIELD_OBJ = 10,
			AVATAR_HOME = 11,
			STRUCTURE = 12,
			WALLPAPER = 13,
			PACK_TICKET = 14,
			DECK_LIMIT = 15
		}

		public enum ItemType
		{
			NONE = 0,
			DELUXE = 1
		}

		public enum PeriodCategory
		{
			NONE = 0,
			EVENT = 1,
			PACK_TICKET = 2,
			DUEL_PASS = 3,
			CAMPAIGN_PACK_TICKET = 4,
			UNPACK_RIGHT = 5
		}

		public enum ItemDetailType
		{
			CARD_BROWSER = 0,
			DECK_BROWSER = 1,
			ITEM_PREVIEW = 2
		}

		public const int k_ItemIdFreeGem = 1;

		public const int k_ItemIdPaidGem = 2;

		public const int k_ItemIdCardRareShine = 100000;

		public const int k_ItemIdCardRareRoyal = 200000;

		public static bool IsValidItem(bool isPerild, int itemCategory, int itemId)
		{
			return false;
		}

		public static bool IsGemItem(bool isPerild, int itemCategory, int itemId)
		{
			return false;
		}

		public static bool IsPaidGemItem(bool isPerild, int itemCategory, int itemId)
		{
			return false;
		}

		public static bool IsTicketItem(bool isPerild, int itemCategory, int itemId)
		{
			return false;
		}

		public static bool IsCardItem(bool isPerild, int itemCategory, int itemId)
		{
			return false;
		}

		public static bool IsConsumeItem(bool isPerild, int itemCategory, int itemId)
		{
			return false;
		}

		public static bool IsPeriodConsumeItem(PeriodCategory periodCategory)
		{
			return false;
		}

		public static bool IsConsumeItem(Category itemCategory)
		{
			return false;
		}

		public static bool IsSkippableCategoryNameItem(bool isPeriod, int itemCategory, int itemId)
		{
			return false;
		}

		public static bool IsSkippableDescItem(bool isPeriod, int itemCategory, int itemId)
		{
			return false;
		}

		public static bool IsSkippableNum(bool isPeriod, int itemCategory, int itemId)
		{
			return false;
		}

		public static BindingItemThumb BindItemThumb(GameObject target, int itemID, float scale = 0f, BindingItemThumb.DxBadgeMode dxBadgeMode = BindingItemThumb.DxBadgeMode.None)
		{
			return null;
		}

		public static BindingItemThumb BindItemThumb(GameObject target, bool isPerild, int itemCategory, int itemID, float scale = 0f, BindingItemThumb.DxBadgeMode dxBadgeMode = BindingItemThumb.DxBadgeMode.None)
		{
			return null;
		}

		public static BindingItemThumb BindItemThumbLarge(GameObject target, int itemID, float scale = 0f)
		{
			return null;
		}

		public static BindingItemThumb BindItemThumbLarge(GameObject target, bool isPerild, int itemCategory, int itemID, float scale = 0f)
		{
			return null;
		}

		public static string GetItemName(int itemID, TextGroupLoadHolder textGroupLoadHolder = null)
		{
			return null;
		}

		public static string GetItemName(bool isPerild, int itemCategory, int itemID, TextGroupLoadHolder textGroupLoadHolder = null)
		{
			return null;
		}

		public static string GetItemNameWithFreePaidCheck(int itemID, TextGroupLoadHolder textGroupLoadHolder = null)
		{
			return null;
		}

		public static string GetItemDesc(int itemID, bool useMobileSfx = false)
		{
			return null;
		}

		public static string GetItemDesc(bool isPeriod, int itemCategory, int itemID, bool useMobileSfx = false, TextGroupLoadHolder textGroupLoadHolder = null)
		{
			return null;
		}

		public static string GetItemCategoryName(bool isPeriod, int category, int itemId, TextGroupLoadHolder textGroupLoadHolder = null)
		{
			return null;
		}

		public static string GetCategoryName(Category category, TextGroupLoadHolder textGroupLoadHolder = null, bool isDx = false)
		{
			return null;
		}

		public static string GetPeriodCategoryName(PeriodCategory periodCategory, TextGroupLoadHolder textGroupLoadHolder = null)
		{
			return null;
		}

		public static string GetTagLabel(int tagId, TextGroupLoadHolder textGroupLoadHolder = null)
		{
			return null;
		}

		public static Dictionary<string, object> GetItemDic(Category category)
		{
			return null;
		}

		public static int GetHasTotalGem()
		{
			return 0;
		}

		public static int GetHasFreeGem()
		{
			return 0;
		}

		public static int GetHasPaidGem()
		{
			return 0;
		}

		public static int GetHasItemQuantity(int itemID)
		{
			return 0;
		}

		public static Dictionary<string, object> GetHasAllItemDic()
		{
			return null;
		}

		public static List<object> GetHasItemList(Category category)
		{
			return null;
		}

		public static bool GetMrkStyleIdFromID(int itemId, out int mrk, out int styleId)
		{
			mrk = default(int);
			styleId = default(int);
			return false;
		}

		public static Category GetCategoryFromID(int itemID)
		{
			return default(Category);
		}

		public static int GetCategoryOffset(Category category)
		{
			return 0;
		}

		public static int SelectValidCategory(bool isPeriod, int categoryID, int itemID)
		{
			return 0;
		}

		public static bool IsDeluxe(bool isPeriod, int categoryID, int itemID)
		{
			return false;
		}

		public static bool IsDeluxe(int itemID)
		{
			return false;
		}

		private static bool IsMatchingCategoryRange(Category category, object value)
		{
			return false;
		}

		[Obsolete]
		public static bool IsTargetItemConfirmDialog(bool isPeriod, int itemCategory)
		{
			return false;
		}

		public static void OpenItemDetail(bool isPeriod, int itemCategory, int itemId, int itemNum = -1, Action callback = null, Dictionary<string, object> itemArgs = null)
		{
		}

		public static ItemDetailType GetItemDetailType(bool isPeriod, int itemCategory, int itemId)
		{
			return default(ItemDetailType);
		}

		public static void OpenItemConfirmDialog(string title, bool isPeriod, int itemCategory, int itemId, int itemNum, Action callback = null, bool hideNum = false, Dictionary<string, object> itemArgs = null)
		{
		}

		public static void OpenItemRecieveDialog(bool isPeriod, int itemCategory, int itemId, int itemNum, bool isSendPresent, Action callback = null)
		{
		}

		public static void OpenItemRecieveDialog(string title, bool isPeriod, int itemCategory, int itemId, int itemNum, bool isSendPresent, Action callback = null)
		{
		}

		public static void OpenItemRecieveDialog(EntryItemListData receiveItemListData, bool isSendPresent, Action action = null, string title = null)
		{
		}

		public static void OpenItemRecieveDialog(string title, EntryItemListData receiveItemListData, bool isSendPresent, Action action = null)
		{
		}

		public static void OpenItemRecieveHighlightDialogs(string title, IReadOnlyList<(EntryItemListData.Context, bool)> receivedItems, Action action = null, int playIdx = 0)
		{
		}

		public static void OpenItemRecieveListOrHighlightDialog(EntryItemListData recievedItems, bool isSendPresent, string title = null, Action action = null)
		{
		}

		public static void OpenItemRecieveHighlightDialog(string title, bool isPeriod, int itemCategory, int itemId, int itemNum, bool isSendPresent, Action callback = null, bool isEffect = true, bool hideNum = false, bool isRecieve = true, Dictionary<string, object> itemArgs = null)
		{
		}

		public static void OpenItemReceiveHighlightDialogBase(string title, bool isPeriod, int itemCategory, int itemId, int itemNum, bool isSendPresent, EntryButtonData[] entryButtons, bool isEffect, bool hideNum, bool isRecieve, Dictionary<string, object> itemArgs = null)
		{
		}

		public static (int, int) GetCardIDandDecoID(int itemId)
		{
			return default((int, int));
		}

		public static BindingGameObjectEx BindDeluxBadge(GameObject target, bool isSimple = false, bool isLarge = false)
		{
			return null;
		}

		private static Dictionary<string, int> GetItemOrder(List<object> list)
		{
			return null;
		}

		private static int ItemSorter(object a, object b, Dictionary<string, int> itemOrder)
		{
			return 0;
		}

		public static List<object> SortItem(List<object> list)
		{
			return null;
		}
	}
}
