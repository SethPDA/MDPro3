using System;
using System.Collections.Generic;
using UnityEngine;
using YgomGame.Utility;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Dialog.CommonDialog
{
	public class CommonDialogContentContainerWidget : ElementWidgetBehaviourBase<CommonDialogContentContainerWidget>
	{
		private readonly string k_ELabelTitleGrp;

		private readonly string k_ELabelText;

		private readonly string k_ELabelScrollText;

		private readonly string k_ELabelImage;

		private readonly string k_ELabelMaintenance;

		private readonly string k_ELabelIconText;

		private readonly string k_ELabelItemContent;

		private readonly string k_ELabelCheckBoxGroup;

		private readonly string k_ELabelButtonGroup;

		private readonly string k_ELabelButtonGroupVertical;

		private CommonDialogTitleWidget m_TitleWidget;

		private CommonDialogTextWidget m_TextWidget;

		private CommonDialogScrollTextWidget m_ScrollTextWidget;

		private CommonDialogImageWidget m_ImageWidget;

		private CommonDialogMaintenanceImageWidget m_MaintenanceWidget;

		private CommonDialogIconTextWidget m_IconTextWidget;

		private CommonDialogItemContentWidget m_ItemContentWidget;

		private CommonDialogCheckBoxGroupWidget m_CheckBoxGroupWidget;

		private CommonDialogButtonGroupWidget m_ButtonGroupWidget;

		private CommonDialogButtonWidget m_CancelButtonWidget;

		private ElementObjectManager m_ItemListWidgetPref;

		private CommonDialogItemListWidget m_ItemListWidget;

		private bool m_RebuildLayoutOnPostAllInserted;

		private List<IContentPostAllInsertedHandler> m_PostAllInsertedHandlers;

		private List<IContentWidgetDirectionalInputListener> m_DirectionalInputListeners;

		private List<IContentLifecycleHandler> m_LifecycleHandlers;

		private List<SelectionButton> m_Buttons;

		private TextGroupLoadHolder m_TextGroupLoadHolder;

		public Action onSendCloseCallback;

		private CommonDialogButtonWidget defaultButton;

		private Action m_CompleteCallback;

		private int m_LoadingCnt;

		public CommonDialogButtonWidget cancelButtonWidget => null;

		public CommonDialogCheckBoxGroupWidget checkBoxGroupWidget => null;

		public CommonDialogButtonGroupWidget buttonGroupWidget => null;

		public TextGroupLoadHolder textGroupLoadHolder => null;

		public ElementObjectManager itemListWidgetPref
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool directionalInputListenerExist => false;

		public static CommonDialogContentContainerWidget Create(ElementObjectManager eom)
		{
			return null;
		}

		protected override void CollectComponents()
		{
		}

		public void InsertEntries(IReadOnlyList<IEntryData> entryDatas, Action onComplete = null, TextGroupLoadHolder textGroupLoadHolder = null)
		{
		}

		private void InsertContentWidget(IEntryData entryData)
		{
		}

		private void OnLoadingCompleteCheck()
		{
		}

		public IContentWidget GetContentWidget(IEntryData entryData)
		{
			return null;
		}

		public void SendMainAnalogInputToListeneres(Vector2 dir)
		{
		}

		public void SendSubAnalogInputToListeneres(Vector2 dir)
		{
		}

		public void SendLeftInputToListeneres()
		{
		}

		public void SendRightInputToListeneres()
		{
		}

		public void SendUpInputToListeneres()
		{
		}

		public void SendDownInputToListeneres()
		{
		}

		private void OnSendClose()
		{
		}

		public bool OnBack()
		{
			return false;
		}

		public CommonDialogContentContainerWidget()
		{
			//((ElementWidgetBehaviourBase<>)(object)this)._002Ector();
		}
	}
}
