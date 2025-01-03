using System;
using UnityEngine;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public class PopupDuelYesOrNo : PopupDuel
    {
        [Header("Popup Duel YesOrNo Reference")]
        public Text description;
        public Action confirmAction;
        public Action cancelAction;
        public override void Show()
        {
            base.Show();
            AudioManager.PlaySE("SE_SYS_VERIFY");
        }
        public override void InitializeSelections()
        {
            base.InitializeSelections();
            description.text = selections[1];
            btnConfirm.transform.GetChild(0).GetComponent<Text>().text = selections[2];
            btnCancel.transform.GetChild(0).GetComponent<Text>().text = selections[3];
        }
        public override void OnConfirm()
        {
            base.OnConfirm();
            confirmAction?.Invoke();
            Hide();
        }
        public override void OnCancel()
        {
            base.OnCancel();
            cancelAction?.Invoke();
            Hide();
        }

    }
}
