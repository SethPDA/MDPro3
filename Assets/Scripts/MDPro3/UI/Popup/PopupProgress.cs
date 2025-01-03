using System;
using UnityEngine;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public class PopupProgress : PopupBase
    {
        [Header("Popup Progress")]
        public Text description;
        public Slider progressBar;
        public Action cancelAction;

        public override void OnCancel()
        {
            base.OnCancel();
            cancelAction?.Invoke();
            Hide();
        }
    }
}

