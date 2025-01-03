using System;
using UnityEngine;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public class PopupInput : PopupBase
    {
        [Header("Popup Select Reference")]
        public InputField input;
        public Action<string> confirmAction;
        public Action cancelAction;

        public InputValidation.ValidationType validationType;
        public override void InitializeSelections()
        {
            base.InitializeSelections();
            input.GetComponent<InputValidation>().type = validationType;
            input.text = selections[1];
        }

        public override void OnCancel()
        {
            base.OnCancel();
            cancelAction?.Invoke();
            Hide();
        }

        public override void OnConfirm()
        {
            base.OnConfirm();
            confirmAction?.Invoke(input.text);
            Hide();
        }
    }
}
