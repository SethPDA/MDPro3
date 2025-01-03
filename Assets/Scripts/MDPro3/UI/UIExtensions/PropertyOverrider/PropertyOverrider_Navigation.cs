using System;
using System.Windows.Forms;
using UnityEngine;
using UnityEngine.UI;

namespace MDPro3.UI.PropertyOverrider
{
    public class PropertyOverrider_Navigation : PropertyOverrider
    {
        [SerializeField] private OverrideProperty_Navigation m_Navigation;

        protected override void Awake()
        {
            if (m_Navigation.m_DefaultValue.mode == Navigation.Mode.None)
                m_Navigation.m_DefaultValue = GetComponent<Selectable>().navigation;
            base.Awake();
        }

        protected override void DefaultOverride()
        {
            base.DefaultOverride();

            var target = GetComponent<Selectable>();
            target.navigation = m_Navigation.m_DefaultValue;
        }

        protected override void MobileOverride()
        {
            base.MobileOverride();

            var target = GetComponent<Selectable>();
            target.navigation = m_Navigation.m_MobileValue;
        }
    }
}
