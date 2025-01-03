using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MDPro3.UI
{
    public class Tabs : MonoBehaviour
    {
        public List<Tab> tabs = new List<Tab>();

        private void Start()
        {
            foreach (Tab tab in tabs)
                SystemEvent.OnResolutionChange += tab.AdjustSize;
        }

        public void Tab(Tab tab)
        {
            foreach (var t in tabs)
            {
                if (t != tab)
                    t.CancelSelect();
            }
        }
        public void AdjustSize()
        {
            foreach (Tab tab in tabs)
                tab.AdjustSize();
        }
    }
}
