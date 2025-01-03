using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public class SuperScrollViewItemForMate : SuperScrollViewItem
    {
        public int code;
        public string mateName;

        public override void Refresh()
        {
            base.Refresh();
            transform.GetChild(0).GetComponent<Text>().text = mateName;
        }

        public override void OnClick()
        {
            base.OnClick();
            if (code == 0) return;
            Program.instance.mate.ViewMate(code);
        }
    }
}
