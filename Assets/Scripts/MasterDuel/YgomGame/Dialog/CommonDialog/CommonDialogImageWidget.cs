using System;
using UnityEngine.UI;
using YgomSystem.ElementSystem;

namespace YgomGame.Dialog.CommonDialog
{
	public class CommonDialogImageWidget : ContentWidgetBase<CommonDialogImageWidget, EntryImageData>, IContentWidgetAsyncLoader
	{
		//private Image m_Image;

		//private LayoutElement m_LayoutElement;

		private Action m_OnCompleteCallback;

		public static CommonDialogImageWidget Create(ElementObjectManager eom)
		{
			return null;
		}

		protected override void CollectComponents()
		{
		}

		protected override void InnerBinding(EntryImageData entryData)
		{
		}

		public void AsyncBinding(IEntryData entryData, Action onComplete)
		{
		}

		private void RefreshLayoutElement()
		{
		}

		//protected override void OnRectTransformDimensionsChange()
		//{
		//}

		//public CommonDialogImageWidget()
		//{
		//	((ContentWidgetBase<, >)(object)this)._002Ector();
		//}
	}
}
