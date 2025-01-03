using TMPro;
using UnityEngine;

namespace MDPro3.UI.PropertyOverrider
{
    public class PropertyOverrider_TextMeshProUGUI : PropertyOverrider
    {
        [SerializeField] private OverrideProperty_Float m_FontSize;
        [SerializeField] private OverrideProperty_Bool m_EnableAutoSize;
        [SerializeField] private OverrideProperty_Float m_FontSizeMin;
        [SerializeField] private OverrideProperty_Float m_FontSizeMax;

        protected override void DefaultOverride()
        {
            base.DefaultOverride();

            var target = GetComponent<TextMeshProUGUI>();
            target.fontSize = m_FontSize.m_DefaultValue;
            target.enableAutoSizing = m_EnableAutoSize.m_DefaultValue;
            target.fontSizeMin = m_FontSizeMin.m_DefaultValue;
            target.fontSizeMax = m_FontSizeMax.m_DefaultValue;
        }

        protected override void MobileOverride()
        {
            base.MobileOverride();

            var target = GetComponent<TextMeshProUGUI>();
            target.fontSize = m_FontSize.m_MobileValue;
            target.enableAutoSizing = m_EnableAutoSize.m_MobileValue;
            target.fontSizeMin = m_FontSizeMin.m_MobileValue;
            target.fontSizeMax = m_FontSizeMax.m_MobileValue;
        }
    }
}
