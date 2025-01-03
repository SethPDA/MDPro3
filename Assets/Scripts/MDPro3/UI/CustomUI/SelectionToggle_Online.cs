using UnityEngine;

namespace MDPro3.UI
{
    public class SelectionToggle_Online : SelectionToggle
    {
        [Header("SelectionToggle Online")]
        [SerializeField] private GameObject targetPage;

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
            targetPage.SetActive(true);
            Program.instance.online.SelectLastSelectable();
        }

        protected override void CallToggleOffEvent()
        {
            base.CallToggleOffEvent();
            targetPage.SetActive(false);
        }

        public void OnLeftSelection()
        {
            AudioManager.PlaySE(SoundLabelClick);
            var leftSelectable = Selectable.navigation.selectOnLeft;
            if (toggled)
            {
                if (leftSelectable != null)
                    leftSelectable.GetComponent<SelectionToggle_Online>().SetToggleOn();
            }
            else
            {
                if (leftSelectable != null)
                    leftSelectable.GetComponent<SelectionToggle_Online>().OnLeftSelection();
            }
        }
        public void OnRightSelection()
        {
            AudioManager.PlaySE(SoundLabelClick);
            var rightSelectable = Selectable.navigation.selectOnRight;
            if (toggled)
            {
                if (rightSelectable != null)
                    rightSelectable.GetComponent<SelectionToggle_Online>().SetToggleOn();
            }
            else
            {
                if (rightSelectable != null)
                    rightSelectable.GetComponent<SelectionToggle_Online>().OnRightSelection();
            }
        }
    }
}

