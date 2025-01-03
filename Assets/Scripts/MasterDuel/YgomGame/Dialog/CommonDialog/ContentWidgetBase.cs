using System.Runtime.CompilerServices;
using UnityEngine;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Dialog.CommonDialog
{
	public abstract class ContentWidgetBase<T, ENTRY> : ElementWidgetUIBehaviourBase<T>, IContentWidget where T : ContentWidgetBase<T, ENTRY> where ENTRY : class, IEntryData
	{
		private CommonDialogContentContainerWidget m_ParentWidget;

		public CommonDialogContentContainerWidget parentWidget => null;

		public void Initialize(CommonDialogContentContainerWidget parentWidget)
		{
		}

		public IContentWidget DuplicateInstantiate()
		{
			return null;
		}

		public void Binding(IEntryData entryData)
		{
		}

		protected abstract void InnerBinding(ENTRY entryData);

		protected ContentWidgetBase()
		{
			//((ElementWidgetUIBehaviourBase<>)(object)this)._002Ector();
		}

		[SpecialName]
		private GameObject YgomGame_002EDialog_002ECommonDialog_002EIContentWidget_002Eget_gameObject()
		{
			return null;
		}

		[SpecialName]
		private Transform YgomGame_002EDialog_002ECommonDialog_002EIContentWidget_002Eget_transform()
		{
			return null;
		}
	}
}
