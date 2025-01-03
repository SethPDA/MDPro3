using System;

namespace YgomGame.Dialog.CommonDialog
{
	public class EntryButtonData : IEntryData
	{
		public CommonDialogButtonGroupWidget.ButtonType buttonType;

		public Action onClickCallback;

		public Action<CommonDialogButtonWidget> onClickWidgetCallback;

		public string onClickUrlScheme;

		public bool interactable;

		public string text;

		public bool closeOnClick;

		public bool isCancel;

		public bool muteClickSe;

		public bool isDefault;

		public string goName;

		public CommonDialogDef.ContentType contentType => default(CommonDialogDef.ContentType);

		public EntryButtonData(string text = null, Action onClickCallback = null, string onClickUrlScheme = null, bool closeOnClick = true, bool interactable = true, bool isCancel = false, bool replaceCallback = false, Action<CommonDialogButtonWidget> onClickWidgetCallback = null, CommonDialogButtonGroupWidget.ButtonType buttonType = CommonDialogButtonGroupWidget.ButtonType.Positive, bool muteClickSe = false, bool isDefault = false, string goName = null)
		{
		}
	}
}
