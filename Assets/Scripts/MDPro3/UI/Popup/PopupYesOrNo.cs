using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public class PopupYesOrNo : PopupBase
    {
        [Header("Popup YesOrNo Reference")]
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
            Hide();
            confirmAction?.Invoke();
        }
        public override void OnCancel()
        {
            base.OnCancel();
            Hide();
            cancelAction?.Invoke();
        }
    }
}
