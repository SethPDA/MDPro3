using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public class CleanTextButton : MonoBehaviour
    {
        public InputField InputField;
        Button button;
        Image image;

        private void Start()
        {
            button = GetComponent<Button>();
            image = GetComponent<Image>();
            button.onClick.AddListener(CleanText);
            InputField.onValueChanged.AddListener(ShowOrNot);
            ShowOrNot("");
        }

        private void ShowOrNot(string value)
        {
            if (InputField.text == "")
            {
                image.color = new Color(1f, 1f, 1f, 0f);
                button.interactable = false;
            }
            else
            {
                image.color = new Color(1f, 1f, 1f, 1f);
                button.interactable = true;
            }
        }

        void CleanText()
        {
            InputField.text = "";
            InputField.onEndEdit.Invoke("");
        }
    }
}
