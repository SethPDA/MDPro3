using UnityEngine;
using UnityEngine.UI;

namespace MDPro3.UI.PropertyOverrider
{
    public class PropertyOverrider_LayoutElement : PropertyOverrider
    {
        [SerializeField] private OverrideProperty_Bool m_IgnoreLayout;
        [SerializeField] private OverrideProperty_Float m_MinWidth;
        [SerializeField] private OverrideProperty_Float m_MinHeight;
        [SerializeField] private OverrideProperty_Float m_PreferredWidth;
        [SerializeField] private OverrideProperty_Float m_PreferredHeight;
        [SerializeField] private OverrideProperty_Float m_FlexibleWidth;
        [SerializeField] private OverrideProperty_Float m_FlexibleHeight;

        protected override void DefaultOverride()
        {
            base.DefaultOverride();

            var target = GetComponent<LayoutElement>();
            target.ignoreLayout = m_IgnoreLayout.m_DefaultValue;
            target.minWidth = m_MinWidth.m_DefaultValue;
            target.minHeight = m_MinHeight.m_DefaultValue;
            target.preferredWidth = m_PreferredWidth.m_DefaultValue;
            target.preferredHeight = m_PreferredHeight.m_DefaultValue;
            target.flexibleWidth = m_FlexibleWidth.m_DefaultValue;
            target.flexibleHeight = m_FlexibleHeight.m_DefaultValue;
        }

        protected override void MobileOverride()
        {
            base.MobileOverride();

            var target = GetComponent<LayoutElement>();
            target.ignoreLayout = m_IgnoreLayout.m_MobileValue;
            target.minWidth = m_MinWidth.m_MobileValue;
            target.minHeight = m_MinHeight.m_MobileValue;
            target.preferredWidth = m_PreferredWidth.m_MobileValue;
            target.preferredHeight = m_PreferredHeight.m_MobileValue;
            target.flexibleWidth = m_FlexibleWidth.m_MobileValue;
            target.flexibleHeight = m_FlexibleHeight.m_MobileValue;
        }
    }   
}

