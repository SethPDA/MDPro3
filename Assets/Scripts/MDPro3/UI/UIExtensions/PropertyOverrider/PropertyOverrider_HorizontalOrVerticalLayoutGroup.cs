using UnityEngine;
using UnityEngine.UI;

namespace MDPro3.UI.PropertyOverrider
{
    public class PropertyOverrider_HorizontalOrVerticalLayoutGroup : PropertyOverrider
    {
        [SerializeField] private OverrideProperty_RectOffset m_Padding;
        [SerializeField] private OverrideProperty_Float m_Spacing;

        protected override void DefaultOverride()
        {
            base.DefaultOverride();

            var target = GetComponent<HorizontalOrVerticalLayoutGroup>();
            target.padding = m_Padding.m_DefaultValue;
            target.spacing = m_Spacing.m_DefaultValue;
        }

        protected override void MobileOverride()
        {
            base.MobileOverride();

            var target = GetComponent<HorizontalOrVerticalLayoutGroup>();
            target.padding = m_Padding.m_MobileValue;
            target.spacing = m_Spacing.m_MobileValue;
        }
    }
}
