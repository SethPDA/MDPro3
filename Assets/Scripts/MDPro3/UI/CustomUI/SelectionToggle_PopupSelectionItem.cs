using MDPro3.UI;
using System;
using UnityEngine;
using UnityEngine.Events;

namespace MDPro3.UI.Popup
{
    public class SelectionToggle_PopupSelectionItem : SelectionToggle_ScrollRectItem
    {
        public string selection;
        public Action clickAction;
        public PopupSelection manager;

        public override void Refresh()
        {
            SetButtonText(selection);
            RemoveAllListeners();
            SetClickEvent(new UnityAction(clickAction));
        }

        protected override void ToggleOn()
        {
            toggled = true;
            isOn = true;
            manager.lastSelectedItem = this;
        }
        public override void ToggleOnNow()
        {
            toggled = true;
            isOn = true;
        }
        protected override void ToggleOff()
        {
            toggled = false;
            isOn = false;
        }
        public override void ToggleOffNow()
        {
            toggled = false;
            isOn = false;
        }
    }
}

