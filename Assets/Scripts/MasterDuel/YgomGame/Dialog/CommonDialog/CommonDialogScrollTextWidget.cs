using System.Collections;
using TMPro;
using UnityEngine.UI;
using YgomSystem.ElementSystem;

namespace YgomGame.Dialog.CommonDialog
{
	public class CommonDialogScrollTextWidget : ContentWidgetBase<CommonDialogScrollTextWidget, EntryScrollTextData>
	{
		private TMP_Text m_Text;

		//private LayoutElement m_Layout;

		public static CommonDialogScrollTextWidget Create(ElementObjectManager eom)
		{
			return null;
		}

		protected override void CollectComponents()
		{
		}

		protected override void InnerBinding(EntryScrollTextData entryData)
		{
		}

		private IEnumerator ApplayHeight(int minHeight)
		{
			return null;
		}

		public CommonDialogScrollTextWidget()
		{
			//((ContentWidgetBase<, >)(object)this)._002Ector();
		}
	}
}
