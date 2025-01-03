using UnityEngine;

namespace MDPro3.UI
{
    public class ButtonListManager : MonoBehaviour
    {
        ButtonList[] buttons;

        private void Start()
        {
             buttons = transform.GetComponentsInChildren<ButtonList>(true);
        }

        public ButtonList GetButtonListByName(string name)
        {
            foreach (ButtonList button in buttons)
                if (button.gameObject.name == name)
                    return button;
            return null;
        }
    }
}
