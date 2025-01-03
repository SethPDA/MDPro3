using TMPro;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame.Dialog.CommonDialog
{
	public class CommonDialogTextWidget : ContentWidgetBase<CommonDialogTextWidget, EntryTextData>
	{
		private GameObject m_Base;

		private TMP_Text m_Text;

		public static CommonDialogTextWidget Create(ElementObjectManager eom)
		{
			return null;
		}

		protected override void CollectComponents()
		{
		}

		protected override void InnerBinding(EntryTextData entryData)
		{
		}

		public CommonDialogTextWidget()
		{
			//((ContentWidgetBase<, >)(object)this)._002Ector();
		}
	}
}
