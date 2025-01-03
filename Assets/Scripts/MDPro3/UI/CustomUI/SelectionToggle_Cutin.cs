using MDPro3.UI;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace MDPro3.UI
{
    public class SelectionToggle_Cutin : SelectionToggle_ScrollRectItem
    {
        public int code;
        public string cardName;

        public override void Refresh()
        {
            Manager.GetElement<TextMeshProUGUI>("ButtonText").text = cardName;
        }
        protected override void CallSubmitEvent()
        {
            AudioManager.PlaySE("SE_MENU_DECIDE");
            if (MonsterCutin.HasCutin(code))
                MonsterCutin.Play(code, 0);
        }
        protected override void CallToggleOnEvent()
        {
            base.CallToggleOnEvent();
            Program.instance.cutin.lastSelectedCutinItem = this;
        }


        protected override void OnClick()
        {
            Program.instance.cutin.lastSelectedCutinItem = this;
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
                var button = Program.instance.cutin.Manager.GetElement("ButtonAutoPlay");
                EventSystem.current.SetSelectedGameObject(button);
            }
        }
    }
}
