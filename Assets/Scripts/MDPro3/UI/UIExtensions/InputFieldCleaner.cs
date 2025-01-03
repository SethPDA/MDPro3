using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace MDPro3.UI
{
    public class InputFieldCleaner : MonoBehaviour
    {
        public TMP_InputField InputField;
        public Button button;

        private void Awake()
        {
            button.onClick.AddListener(CleanText);
            button.gameObject.SetActive(false);
            InputField.onValueChanged.AddListener(ShowCleanButton);
        }
        private void ShowCleanButton(string value)
        {
            button.gameObject.SetActive(InputField.text != string.Empty);
        }
        private void CleanText()
        {
            InputField.text = string.Empty;
            InputField.onEndEdit.Invoke(string.Empty);
        }

    }
}
