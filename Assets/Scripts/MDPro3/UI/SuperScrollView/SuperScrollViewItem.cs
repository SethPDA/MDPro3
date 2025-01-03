using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public class SuperScrollViewItem : MonoBehaviour
    {
        public int id;
        public SuperScrollView handler;

        private void Start()
        {
            if (TryGetComponent<Button>(out var button))
                button.onClick.AddListener(OnClick);
        }

        public virtual void Refresh()
        {
            
        }

        public virtual void OnClick()
        {

        }
    }
}
