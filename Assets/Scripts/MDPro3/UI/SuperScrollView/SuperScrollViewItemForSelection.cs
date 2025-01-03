using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public class SuperScrollViewItemForSelection : SuperScrollViewItem
    {
        public string selection;
        public Action onClick;
        public Button button;
        public Text text;
        public override void Refresh()
        {
            base.Refresh();
            text.text = selection;
            button.onClick.RemoveAllListeners();
            button.onClick.AddListener(RefreshOnClick);
        }

        void RefreshOnClick()
        {
            onClick?.Invoke();
        }
    }
}
