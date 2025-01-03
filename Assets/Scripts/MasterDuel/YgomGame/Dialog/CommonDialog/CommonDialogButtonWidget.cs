using System;
using TMPro;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Dialog.CommonDialog
{
	public class CommonDialogButtonWidget : ContentWidgetBase<CommonDialogButtonWidget, EntryButtonData>//, IConentWidgetSendableClose
	{
		private readonly string k_ELabelLabel;

		private SelectionButton m_Button;

		private TMP_Text m_Text;

		private Action m_OnClickCallback;

		private Action<CommonDialogButtonWidget> m_OnClickWidgetCallback;

		private string m_OnClickUrlScheme;

		private bool m_CloseOnClick;

		public Action onSendCloseCallback;

		public SelectionButton button => null;

		private Action YgomGame_002EDialog_002ECommonDialog_002EIConentWidgetSendableClose_002EonSendCloseCallback
		{
			set
			{
			}
		}

		public static CommonDialogButtonWidget Create(ElementObjectManager eom)
		{
			return null;
		}

		protected override void CollectComponents()
		{
		}

		protected override void InnerBinding(EntryButtonData entryData)
		{
		}

		public void SetAsDefault(bool isDefault = true)
		{
		}

		private void OnClick()
		{
		}

		public CommonDialogButtonWidget()
		{
			//((ContentWidgetBase<, >)(object)this)._002Ector();
		}
	}
}
