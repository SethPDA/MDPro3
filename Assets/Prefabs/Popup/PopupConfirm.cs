using TMPro;
using UnityEngine;


namespace MDPro3.UI.Popup
{
    public class PopupConfirm : Popup
    {
        protected override void InitializeSelections()
        {
            base.InitializeSelections();
            Manager.GetElement<TextMeshProUGUI>("FrameText").text = args[1];
        }

        public override void Show()
        {
            base.Show();
            AudioManager.PlaySE("SE_SYS_VERIFY");
        }
    }
}

