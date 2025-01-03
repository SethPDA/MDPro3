using System;
using UnityEngine;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public class PopupDuelInput : PopupDuel
    {
        [Header("Popup Duel Input")]
        public Action<string> confirmAction;
        public Action cancelAction;
        public InputField input;

        public InputValidation.ValidationType validationType;

        public override void InitializeSelections()
        {
            base.InitializeSelections();
            btnConfirm.transform.GetChild(0).GetComponent<Text>().text = selections[1];
            btnCancel.transform.GetChild(0).GetComponent<Text>().text = selections[2];
            input.text = selections[3];
            input.GetComponent<InputValidation>().type = validationType;
            if (cancelAction == null)
            {
                btnCancel.gameObject.SetActive(false);
                float height = btnConfirm.GetComponent<RectTransform>().anchoredPosition.y;
                btnConfirm.GetComponent<RectTransform>().anchoredPosition = new Vector2(0f, height);
            }

            OcgCore.inputMode = true;
            Program.instance.ocgcore.GreenBackgroundOff();
        }

        public override void OnConfirm()
        {
            base.OnConfirm();
            confirmAction?.Invoke(input.text);
            Hide();
        }
        public override void OnCancel()
        {
            base.OnCancel();
            cancelAction?.Invoke();
            Hide();
        }

        private void OnDestroy()
        {
            OcgCore.inputMode = false;
        }
    }
}
