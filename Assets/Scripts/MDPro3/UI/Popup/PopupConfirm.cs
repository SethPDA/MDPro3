using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public class PopupConfirm : PopupBase
    {
        [Header("Popup Confirm")]
        public Text description;
        public override void InitializeSelections()
        {
            base.InitializeSelections();
            description.text = selections[1];
        }
        public override void Show()
        {
            base.Show();
            AudioManager.PlaySE("SE_SYS_VERIFY");
        }
        public override void OnConfirm()
        {
            base.OnConfirm();
            Hide();
        }
    }
}
