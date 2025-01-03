using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MDPro3.UI.Popup
{
    public class PopupProgress : Popup
    {
        [Header("Popup Progress")]
        public Slider progressBar;
        public TextMeshProUGUI text;
        public Action cancelAction;

        protected override void OnCancel()
        {
            cancelAction?.Invoke();
            Hide();
        }
    }
}
