using System;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.MDMarkup;
using YgomSystem.Network;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Menu
{
	public class NotificationViewController : BaseBlurOverlayViewController, IDynamicChangeDispHeaderSupported
	{
		internal enum Type
		{
			NOTIFICATION = 0,
			MAINTENANCE = 1,
			BUG = 2
		}

		internal class Data
		{
			internal readonly Type type;

			internal readonly int id;

			internal readonly string category;

			internal readonly Color categoryColor;

			internal readonly string date;

			internal readonly string head;

			internal readonly string body;

			internal readonly int sort;

			internal readonly MDMarkupBannerContext bannerContext;

			internal bool isAlreadyRead;

			public Data(Type type, int id, string category, Color categoryColor, string date, string head, string body, int sort, bool isAlreadyRead, MDMarkupBannerContext bannerContext)
			{
			}
		}

		private readonly string SCROLL_LABEL;

		private readonly string TXT_CATEGORY_LABEL;

		private readonly string IMG_CATEGORY_LABEL;

		private readonly string ROOT_CATEGORY_LABEL;

		private readonly string ROOT_FOOTER_LABEL;

		private readonly string TXT_HEAD_LABEL;

		private readonly string TXT_BODY_LABEL;

		private readonly string TXT_EMPTY_LABEL;

		private readonly string BTN_LABEL;

		private readonly string BTN_NOTIFICATION_LABEL;

		private readonly string BTN_MAINTENANCE_LABEL;

		private readonly string BTN_BUG_LABEL;

		private readonly string BTN_CLOSE_LABEL;

		private readonly string BTN_TAP_BACK_LABEL;

		private readonly string IMG_BADGE_LABEL;

		private readonly string IMG_LABEL;

		private readonly string BTN_SC_L_LABEL;

		private readonly string BTN_SC_R_LABEL;

		public const string ARG_KEY_CLOSE_CALLBACK = "OnClosedCallback";

		private Type currentType;

		[SerializeField]
		private Color defaultCategoryColor;

		private InfinityScrollView isv;

		private List<Data> notificationDatas;

		private List<Data> maintenanceDatas;

		private List<Data> bugDatas;

		protected override System.Type[] textIds => null;

		protected override bool defaultBlurOverlay => false;

		internal static string GetTypeLabel(Type type)
		{
			return null;
		}

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		protected override void OnTransitionStart(TransitionType type)
		{
		}

		public override bool OnBack()
		{
			return false;
		}

		private void CallAPIGetList(Action onSuccess = null)
		{
		}

		private void CallAPINotificationRead(int id, Action onFinish = null)
		{
		}

		public static void HandleResultCode(Handle handle, Action onSuccess = null, Action<NotificationCode> onFailed = null)
		{
		}

		private int GetDatasCount(Type type)
		{
			return 0;
		}

		private void UpdateAll()
		{
		}

		private void UpdateNotification(Type type)
		{
		}

		private void SetBadge(Type type, bool isAlreadyReadType)
		{
		}

		private void UpdateScrollView(Type type)
		{
		}

		private void UpdateEntityCallback(GameObject go, int index)
		{
		}

		public HeaderViewController.IsDispHeader IsDispContents()
		{
			return default(HeaderViewController.IsDispHeader);
		}
	}
}
