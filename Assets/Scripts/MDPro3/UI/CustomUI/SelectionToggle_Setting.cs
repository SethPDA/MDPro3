using MDPro3.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public class SelectionToggle_Setting : SelectionToggle
    {
        [SerializeField] private ScrollRect scrollRect;

        protected override void Awake()
        {
            base.Awake();

            exclusiveToggle = true;
            canToggleOffSelf = false;
            toggleWhenSelected = true;
        }

        protected override void CallToggleOnEvent()
        {
            base.CallToggleOnEvent();
            if (!scrollRect.gameObject.activeSelf)
            {
                scrollRect.gameObject.SetActive(true);
                ScrollRectToTop();
            }

            Program.instance.setting.lastSelectedToggle = this;
        }

        protected override void CallToggleOffEvent()
        {
            base.CallToggleOffEvent();
            scrollRect.gameObject.SetActive(false);
        }

        protected override void OnSubmit()
        {
            base.OnSubmit();
            EventSystem.current.SetSelectedGameObject(scrollRect.content.GetChild(0).gameObject);
        }

        public void ScrollRectToTop()
        {
            scrollRect.verticalScrollbar.value = 1f;
        }
    }
}
