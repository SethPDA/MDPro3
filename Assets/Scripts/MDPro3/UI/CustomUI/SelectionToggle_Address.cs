using MDPro3.Net;
using UnityEngine;
using UnityEngine.EventSystems;

namespace MDPro3.UI
{
    public class SelectionToggle_Address : SelectionToggle_ScrollRectItem
    {
        [Header("SelectionToggle Address")]
        public string addressName;
        public string addressHost;
        public string addressPort;
        public string addressPassword;

        public override void Refresh()
        {
            SetButtonText(addressName);
        }

        protected override void CallSubmitEvent()
        {
            base.CallSubmitEvent();
            AudioManager.PlaySE("SE_MENU_DECIDE");
            Program.instance.online.inputHost.text = addressHost;
            Program.instance.online.OnHostChange(addressHost);
            Program.instance.online.inputPort.text = addressPort;
            Program.instance.online.OnPortChange(addressPort);
            Program.instance.online.inputPassword.text = addressPassword;
            Program.instance.online.OnPasswordChange(addressPassword);
        }

        protected override void CallToggleOnEvent()
        {
            base.CallHoverOnEvent();
            Program.instance.online.lastSelectedAddressItem = this;
        }

        protected override void OnClick()
        {
            Program.instance.online.lastSelectedAddressItem = this;
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
                var button = Program.instance.online.Manager.GetElement("ButtonJoin");
                EventSystem.current.SetSelectedGameObject(button);
            }
        }

        public void OnDelete()
        {
            foreach (var address in Program.instance.online.addresses)
            {
                if (address.name == addressName)
                {
                    Program.instance.online.addresses.Remove(address);
                    Program.instance.online.Save();
                    Program.instance.online.Print();
                    break;
                }
            }
        }
        public void OnMoveUp()
        {
            var address = new Online.HostAddress();
            address.name = addressName;
            address.host = addressHost;
            address.port = addressPort;
            address.password = addressPassword;
            Program.instance.online.addresses.RemoveAt(index);
            var targetID = index;
            if (index > 0)
                targetID--;
            Program.instance.online.addresses.Insert(targetID, address);
            Program.instance.online.Save();
            Program.instance.online.Print();
        }
        public void OnMoveDown()
        {
            var address = new Online.HostAddress();
            address.name = addressName;
            address.host = addressHost;
            address.port = addressPort;
            address.password = addressPassword;
            Program.instance.online.addresses.RemoveAt(index);
            var targetID = index;
            if (index < Program.instance.online.addresses.Count)
                targetID++;
            Program.instance.online.addresses.Insert(targetID, address);
            Program.instance.online.Save();
            Program.instance.online.Print();
        }

    }
}
