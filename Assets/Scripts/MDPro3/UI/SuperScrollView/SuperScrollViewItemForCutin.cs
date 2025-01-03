using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public class SuperScrollViewItemForCutin : SuperScrollViewItem
    {
        public int code;
        public string cardName;

        public override void Refresh()
        {
            base.Refresh();
            transform.GetChild(0).GetComponent<Text>().text = cardName;
        }

        public override void OnClick()
        {
            base.OnClick();
            if (MonsterCutin.HasCutin(code))
                MonsterCutin.Play(code, 0);
        }
    }
}
