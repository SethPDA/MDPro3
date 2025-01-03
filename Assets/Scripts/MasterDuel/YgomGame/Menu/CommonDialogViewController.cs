using System;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.Dialog.CommonDialog;
using YgomSystem.ElementSystem;

namespace YgomGame.Menu
{
	public class CommonDialogViewController : DialogViewControllerBase, IBokeSupported
	{
		private const string k_ArgKeyEntryDatas = "entryDatas";

		public const string k_ArgKeyOpenSe = "opense";

		public const string k_ArgKeyViewStyleOverride = "viewStyleOverride";

		public const string k_ArgKeyViewPathOverride = "viewPathOverride";

		public const string k_ArgKeyAlignmentOptions = "AlignmentOptions";

		private readonly string k_ELabelContent;

		private readonly string k_ELabelBackKeyShortcutButton;

		[SerializeField]
		private ElementObjectManager m_ItemListWidgetPref;

		private CommonDialogContentContainerWidget m_ContentWidget;

		private bool m_DoneSelectorLabelUnique;

		private static GameObject prefab;

		protected override bool setSurfaceActiveOnInitialize => false;

		private static bool LoadPrefab()
		{
			return false;
		}

		public static void OpenConfirmationDialog(string title, string message, string buttonLabel, Action action, Dictionary<string, object> args = null, bool allowCancel = true, CommonDialogTitleWidget.IconType iconType = CommonDialogTitleWidget.IconType.None, CommonDialogButtonGroupWidget.ButtonType buttonType = CommonDialogButtonGroupWidget.ButtonType.Positive)
		{
		}

		public static void OpenConfirmationDialogScroll(string title, string message, string buttonLabel, Action action, Dictionary<string, object> args = null, bool allowCancel = true, int height = 120, CommonDialogTitleWidget.IconType iconType = CommonDialogTitleWidget.IconType.None, CommonDialogButtonGroupWidget.ButtonType buttonType = CommonDialogButtonGroupWidget.ButtonType.Positive)
		{
		}

		public static void OpenYesNoConfirmationDialogScroll(string title, string message, Action action, Action noAction = null, string yesLabel = null, string noLabel = null, bool allowCancel = true, int height = 120, Dictionary<string, object> args = null, CommonDialogTitleWidget.IconType iconType = CommonDialogTitleWidget.IconType.None, CommonDialogButtonGroupWidget.ButtonType yesButtonType = CommonDialogButtonGroupWidget.ButtonType.Positive, bool selectedNoButton = false)
		{
		}

		public static void OpenErrorDialog(string title, string message, string buttonLabel, Action action, Dictionary<string, object> args = null, bool allowCancel = true, CommonDialogTitleWidget.IconType iconType = CommonDialogTitleWidget.IconType.None, CommonDialogButtonGroupWidget.ButtonType buttonType = CommonDialogButtonGroupWidget.ButtonType.Positive)
		{
		}

		public static void OpenAlertDialog(string title, string message, Action action, string buttonLabel = null, Dictionary<string, object> args = null, bool allowCancel = true, CommonDialogButtonGroupWidget.ButtonType buttonType = CommonDialogButtonGroupWidget.ButtonType.Positive)
		{
		}

		public static void OpenConfirmationPartDialog(string title, string message, string buttonLabel, Action action, Dictionary<string, object> args = null, bool allowCancel = true, CommonDialogTitleWidget.IconType iconType = CommonDialogTitleWidget.IconType.None, CommonDialogButtonGroupWidget.ButtonType buttonType = CommonDialogButtonGroupWidget.ButtonType.Positive)
		{
		}

		public static void OpenYesNoConfirmationDialog(string title, string message, Action action, Action noAction = null, Dictionary<string, object> args = null, string yesLabel = null, string noLabel = null, bool allowCancel = true, CommonDialogTitleWidget.IconType iconType = CommonDialogTitleWidget.IconType.None, CommonDialogButtonGroupWidget.ButtonType yesButtonType = CommonDialogButtonGroupWidget.ButtonType.Positive, bool selectedNoButton = false)
		{
		}

		public static void OpenNoticeYesNoDialog(string title, string message, Action action, Action noAction = null, string yesLabel = null, string noLabel = null, Dictionary<string, object> args = null, bool allowCancel = true, CommonDialogButtonGroupWidget.ButtonType yesButtonType = CommonDialogButtonGroupWidget.ButtonType.Positive, bool selectedNoButton = false)
		{
		}

		public static void OpenItemConfirmDialog(string title, string message, int itemId, Action action, string buttonLabel = null, string itemMessage = null, Dictionary<string, object> args = null)
		{
		}

		public static void OpenItemConfirmDialog(string title, string message, bool isPeriod, int itemCategory, int itemId, Action action, string buttonLabel = null, string itemMessage = null, Dictionary<string, object> args = null)
		{
		}

		public static void OpenCheckBoxDialog(string title, string message, List<EntryCheckBoxListData.EntryCheckBoxData> checkBoxList, bool isEnableMulti, Action<List<bool>> action = null, Action noAction = null, string buttonLabel = null, string noButtonLabel = null, bool interactable = false, Dictionary<string, object> args = null)
		{
		}

		public static void Open(IReadOnlyList<IEntryData> entryDatas, Dictionary<string, object> args = null)
		{
		}

		public override void NotificationStackEntry()
		{
		}

		protected override void OnCreatedView()
		{
		}

		public override float Progress()
		{
			return 0f;
		}

		private void OnSendCloseByWidgets()
		{
		}

		public override bool OnBack()
		{
			return false;
		}
	}
}
