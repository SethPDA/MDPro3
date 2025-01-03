using MDPro3.UI;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace MDPro3.UI
{
    public class SelectionToggle_Mate : SelectionToggle_ScrollRectItem
    {
        public int code;
        public string mateName;

        public override void Refresh()
        {
            SetButtonText(mateName);
        }
        protected override void CallSubmitEvent()
        {
            AudioManager.PlaySE("SE_MENU_DECIDE");
            if (code == 0) return;
            Program.instance.mate.ViewMate(code);
        }
        protected override void CallToggleOnEvent()
        {
            base.CallToggleOnEvent();
            Program.instance.mate.lastSelectedMateItem = this;
        }


        protected override void OnClick()
        {
            Program.instance.mate.lastSelectedMateItem = this;
            CallSubmitEvent();
        }

        protected override void ToggleOn()
        {
            toggled = true;
            isOn = true;
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

        protected override void OnNavigation(AxisEventData eventData)
        {
            base.OnNavigation(eventData);

            if (eventData.moveDir == MoveDirection.Right)
            {
                UserInput.NextSelectionIsAxis = true;
                var button = Program.instance.mate.Manager.GetElement("ButtonInteraction");
                EventSystem.current.SetSelectedGameObject(button);
            }
        }
    }
}
