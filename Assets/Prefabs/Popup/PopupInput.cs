using System;
using TMPro;
using UnityEngine;

namespace MDPro3.UI.Popup
{
    public class PopupInput : Popup
    {
        [Header("Popup Input Reference")]
        public TMP_InputField input;
        public Action<string> decideAction;
        public Action cancelAction;
        public TmpInputValidation.ValidationType validationType;

        protected override void InitializeSelections()
        {
            base.InitializeSelections();
            input.GetComponent<TmpInputValidation>().type = validationType;
            input.text = args[1];
        }

        protected override void OnCancel()
        {
            cancelAction?.Invoke();
            Hide();
        }

        protected override void OnDecide()
        {
            decideAction?.Invoke(input.text);
            Hide();
        }

    }
}

