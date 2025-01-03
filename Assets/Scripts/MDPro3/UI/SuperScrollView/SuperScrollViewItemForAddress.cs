using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MDPro3.Net;

namespace MDPro3.UI
{
    public class SuperScrollViewItemForAddress : SuperScrollViewItem
    {
        public string addressName;
        public string addressHost;
        public string addressPort;
        public string addressPassword;

        public override void Refresh()
        {
            base.Refresh();
            transform.GetChild(0).GetComponent<Text>().text = addressName;
        }

        public override void OnClick()
        {
            base.OnClick();
            Program.instance.online.inputHost.text = addressHost;
            Program.instance.online.OnHostChange(addressHost);
            Program.instance.online.inputPort.text = addressPort;
            Program.instance.online.OnPortChange(addressPort);
            Program.instance.online.inputPassword.text = addressPassword;
            Program.instance.online.OnPasswordChange(addressPassword);
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
            Program.instance.online.addresses.RemoveAt(id);
            var targetID = id;
            if (id > 0)
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
            Program.instance.online.addresses.RemoveAt(id);
            var targetID = id;
            if (id < Program.instance.online.addresses.Count)
                targetID++;
            Program.instance.online.addresses.Insert(targetID, address);
            Program.instance.online.Save();
            Program.instance.online.Print();
        }
    }
}
