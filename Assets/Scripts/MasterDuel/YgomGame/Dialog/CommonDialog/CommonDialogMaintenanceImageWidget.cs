using System;
using TMPro;
using UnityEngine.UI;
using YgomSystem.ElementSystem;

namespace YgomGame.Dialog.CommonDialog
{
	public class CommonDialogMaintenanceImageWidget : ContentWidgetBase<CommonDialogMaintenanceImageWidget, EntryMaintenanceImageData>
	{
		private TMP_Text m_TextTitle;

		private TMP_Text m_TextDate;

		//private Image m_Image;

		private Action m_OnCompleteCallback;

		public static CommonDialogMaintenanceImageWidget Create(ElementObjectManager eom)
		{
			return null;
		}

		protected override void CollectComponents()
		{
		}

		protected override void InnerBinding(EntryMaintenanceImageData entryData)
		{
		}

		public void AsyncBinding(IEntryData entryData, Action onComplete)
		{
		}

		public CommonDialogMaintenanceImageWidget()
		{
			//((ContentWidgetBase<, >)(object)this)._002Ector();
		}
	}
}
