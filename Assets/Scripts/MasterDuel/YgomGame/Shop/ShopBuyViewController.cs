using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.UI;

namespace YgomGame.Shop
{
	public class ShopBuyViewController : BaseMenuViewController, IDynamicChangeDispHeaderSupported
	{
		public class PurchaseHandler
		{
			private readonly Action<Action, Action> m_OnOpenConfirmCallback;

			private readonly Action<Dictionary<string, object>, Action> m_OnRequestPurchaseCallback;

			private readonly Action m_OnPostProcessPurchaseCallback;

			public PurchaseHandler(Action<Action, Action> onOpenConfirmCallback, Action<Dictionary<string, object>, Action> onRequestPurchaseCallback, Action onPostProcessPurchaseCallback)
			{
			}

			public void OpenConfirm(Action onDecided, Action onCanceled)
			{
			}

			public void RequestPurchase(Dictionary<string, object> purchaseArgs, Action onComplete)
			{
			}

			public void PostProcessPurchase()
			{
			}
		}

		public enum OpenMode
		{
			Push = 0,
			PushOnHome = 1,
			ReplaceOpen = 2
		}

		private const string k_PrefPath = "Shop/ShopBuy";

		internal const string k_PurchaseArgs_Slot = "slot";

		internal const string k_RouteKey_PurchaseHandler = "purchaseHandler";

		private const string K_ArgKeyShopId = "productId";

		private const string K_ArgKeyPageIdx = "pageIdx";

		private const string K_ArgKeySendChangedShopIdOnLaunch = "sendChangedShopId";

		private const string K_ArgKeyPageProductCollection = "pageProductCollection";

		private const string K_ArgKeyConfirmSkipped = "confirmSkipped";

		internal const string K_ArgKeyBlockPurchase = "blockPurchase";

		internal const string K_ResultKey_ChangedShopId = "ShopBuy_ChangedShopId";

		internal const string K_ResultKey_RequestedWebApi = "ShopBuy_RequestedWebApi";

		internal const string K_ResultKey_RequestDialogTitle = "ShopBuy_RequestDialogTitle";

		internal const string K_ResultKey_RequestDialogMessage = "ShopBuy_RequestDialogMessage";

		private readonly string k_ELabelAnalogDirectionItem;

		private readonly string k_ELabelShortcutButtonL1;

		private readonly string k_ELabelShortcutButtonR1;

		private readonly string k_ELabelShortcutIconL1;

		private readonly string k_ELabelShortcutIconR1;

		private readonly string k_ELabelTicketGroup;

		private readonly string k_ELabelTicketIcon;

		private readonly string k_ELabelTicketNumText;

		private readonly string k_ELabelPrevButton;

		private readonly string k_ELabelNextButton;

		private readonly string k_ELabelPreviewContainer;

		private readonly string k_ELabelBadge;

		private readonly string k_ELabelCategoryNameText;

		private readonly string k_ELabelCategoryNameBorder;

		private readonly string k_ELabelProductNameText;

		private readonly string k_ELabelDescText;

		private readonly string k_ELabelDescScrollRect;

		private readonly string k_ELabelProductViewer;

		private readonly string k_ELabelHighlightList;

		private readonly string k_ELabelNewGroup;

		private readonly string k_ELabelNewText;

		private readonly string k_ELabelInformButtonGroup;

		private readonly string k_ELabelBuyButtonGroup;

		private readonly string k_ELabelShortcutKeyFooterRoot;

		private readonly string k_ALabelConfirmRegDialogProductWidget;

		private readonly string k_ALabelConfirmRegDialogTextWidget;

		private readonly string k_ALabelBuyActionSheetPositive;

		private const string k_TLabelStyleNormal = "Style_Normal";

		private const string k_TLabelStyleHighlight = "Style_Highlight";

		private const string k_TLabelLimitAlert_OFF = "LimitAlert_OFF";

		private const string k_TLabelLimitAlert_ON = "LimitAlert_ON";

		private readonly string k_TLabelPagingNextOut;

		private readonly string k_TLabelPagingBackOut;

		private readonly string k_TLabelPagingNextIn;

		private readonly string k_TLabelPagingBackIn;

		private ShopSettings m_ShopSettings;

		private ShopPreviewContainer m_ShopPreviewContainer;

		private ShopShortcutKeyFooter m_ShortcutKeyFooter;

		private SelectionButton m_PrevButton;

		private SelectionButton m_NextButton;

		private ProductContext m_ProductContext;

		private int m_PageIdx;

		private IReadOnlyList<ProductContext> m_PageProducts;

		private PriceContext m_HeaderTicketPriceCtx;

		private ExtendedScrollRect m_DescScrollRect;

		private ProductViewerWidget m_ProductViewerWidget;

		private InformButtonGroupWidget m_InformButtonGroupWidget;

		private HighlightWidget m_HighlightWidget;

		private BuyButtonGroupWidget m_BuyButtonGroupWidget;

		private bool m_RefreshTrigger;

		private int m_PreviewMateItemId;

		private int m_PreviewMateHighlightIdx;

		private bool m_ExistsMonsterCutin;

		private List<HighlightContext> m_HighlightContexts;

		private List<ProductViewerWidget.IThumbPlayer> m_ViewerPlayers;

		private List<int> m_CardBrowseMrks;

		private List<int> m_CardBrowseRareList;

		private List<HighlightContext> m_CardBrowseContexts;

		private List<Tween> m_SpecialTimeTweens;

		private GameObject m_ActionSheetTemplate;

		private bool m_ProductClosed;

		private Dictionary<string, object> m_SendResultDicCache;

		private bool m_IsReady;

		private bool m_OnLaunchCheckTutorialReserve;

		private Dictionary<string, object> sendResultDic => null;

		protected override bool setSurfaceActiveOnInitialize => false;

		protected override Type[] textIds => null;

		public HeaderViewController.IsDispHeader IsDispContents()
		{
			return default(HeaderViewController.IsDispHeader);
		}

		private string GetTLabelPagingOut(int direction)
		{
			return null;
		}

		private string GetTLabelPagingIn(int direction)
		{
			return null;
		}

		public static void OpenOnHome(int shopId, int[] pageShopIds = null, Dictionary<string, object> args = null)
		{
		}

		public static void Open(int shopId, bool skipRequest = false, int[] pageShopIds = null, OpenMode openMode = OpenMode.Push, Dictionary<string, object> args = null)
		{
		}

		public static void OpenProducts(int idx, ProductContextCollection pageProductCollection, OpenMode openMode = OpenMode.Push, Dictionary<string, object> args = null)
		{
		}

		public static void OpenProducts(int idx, IReadOnlyList<ProductContext> pageProducts, OpenMode openMode = OpenMode.Push, Dictionary<string, object> args = null)
		{
		}

		public static void OpenProduct(int shopId, OpenMode openMode = OpenMode.Push, Dictionary<string, object> args = null)
		{
		}

		private static void InnerOpen(OpenMode openMode = OpenMode.Push, Dictionary<string, object> args = null)
		{
		}

		public static void CheckLaunch(int shopId, bool skipRequest, Action onSuccess, Action onFailed = null)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		private void OnEnable()
		{
		}

		private IEnumerator Start()
		{
			return null;
		}

		protected override void OnTransitionEnd(TransitionType type)
		{
		}

		public override void OnFocusChanged(bool setfocus)
		{
		}

		public override bool OnBack()
		{
			return false;
		}

		public override void NotificationStackRemove()
		{
		}

		private void ToNextPage()
		{
		}

		private void ToPrevPage()
		{
		}

		private void ChangePage(int dstIdx, int direction = 0)
		{
		}

		private IEnumerator yPlayPaging(int direction = 0)
		{
			return null;
		}

		private void CheckTutorialMonsterCutin()
		{
		}

		private void RefreshPageButtons()
		{
		}

		private void RefreshProduct()
		{
		}

		private void RefreshProductStatus()
		{
		}

		private void RefreshTicketGroup()
		{
		}

		private void RefreshTicketAmount()
		{
		}

		private void SetLimitAlertStyle(bool isAlertOn)
		{
		}

		private void OnClickNextButton()
		{
		}

		private void OnClickPrevButton()
		{
		}

		private void OnInputAnalogDirection(SelectorManager.AnalogType analogType, PadInputDirection dir)
		{
		}

		private void OnClickShortcutL1()
		{
		}

		private void OnClickShortcutR1()
		{
		}

		private void OnClickTicketHeader()
		{
		}

		private void OnClickMate()
		{
		}

		private void OnClickPlayShortcut()
		{
		}

		private void UpdateHighlightWidgetGamePad()
		{
		}

		private void UpdateShortcutIcon()
		{
		}

		private void UpdateFooter()
		{
		}

		private void OnUpInputHilightThumb()
		{
		}

		private void OnClickHilightThumb(HighlightWidget.IThumbWidget thumbWidget)
		{
		}

		private void OnClickHilightPlay(HighlightWidget.IThumbWidget thumbWidget)
		{
		}

		private void OnDeviceChange(SelectorManager.InputDevice inputDevice)
		{
		}

		private void OnChangedSelectionItem(SelectionItem prevItem, SelectionItem currentItem)
		{
		}

		private void OnClickProductBuy(PriceContext priceContext, bool bySubPricesSheet = false)
		{
		}

		private void ConfirmPurchase(PriceContext priceContext)
		{
		}

		private void RequestBuyProduct(PriceContext priceContext, Dictionary<string, object> purchaseArgs = null, Action onComplete = null)
		{
		}

		private void BuyAfterRefresh(bool isSuccess)
		{
		}

		private bool ExistsAllProducts()
		{
			return false;
		}

		private void ReimportExistsProducts()
		{
		}

		private void PostProcessBuySuccessResult()
		{
		}
	}
}
