using System;
using TMPro;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Dialog.CommonDialog
{
	public class CommonDialogCheckBoxWidget : ElementWidgetBehaviourBase<CommonDialogCheckBoxWidget>
	{
		private readonly string k_ELabelText;

		private readonly string k_ELabelToggle;

		private int index;

		private TMP_Text m_Text;

		private UnityEngine.UI.Toggle m_Toggle;

		private SelectionButton m_Button;

		public Action<int, bool> OnValueChanegedCallBack;

		public bool isOn
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static CommonDialogCheckBoxWidget Create(ElementObjectManager eom)
		{
			return null;
		}

		protected override void CollectComponents()
		{
		}

		public CommonDialogCheckBoxWidget Binding(EntryCheckBoxListData.EntryCheckBoxData entryData, int index)
		{
			return null;
		}

		private void OnClick()
		{
		}

		public CommonDialogCheckBoxWidget()
		{
			//((ElementWidgetBehaviourBase<>)(object)this)._002Ector();
		}
	}
}
