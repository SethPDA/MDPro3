using System;
using TMPro;
using UnityEngine;

namespace MDPro3.UI.Popup
{
    public class PopupYesOrNo : Popup
    {
        public Action decideAction;
        public Action cancelAction;

        protected override void InitializeSelections()
        {
            base.InitializeSelections();
            Manager.GetElement<TextMeshProUGUI>("FrameText").text = args[1];
            Manager.GetElement<SelectionButton>("DecideButton").SetButtonText(args[2]);
            Manager.GetElement<SelectionButton>("CancelButton").SetButtonText(args[3]);
            if(args.Count > 4)
                Manager.GetElement("Icon").SetActive(true);
        }

        public override void Show()
        {
            base.Show();
            AudioManager.PlaySE("SE_SYS_VERIFY");
        }

        protected override void OnDecide()
        {
            decideAction?.Invoke();
            Hide();
        }

        protected override void OnCancel()
        {
            cancelAction?.Invoke();
            Hide();
        }
    }
}
