using UnityEngine;
using UnityEngine.UI;

namespace MDPro3.UI.PropertyOverrider
{
    public class PropertyOverrider_Slider : PropertyOverrider
    {
        [SerializeField] OverrideProperty_Float m_MinValue;
        [SerializeField] OverrideProperty_Float m_MaxValue;

        protected override void DefaultOverride()
        {
            base.DefaultOverride();

            var target = GetComponent<Slider>();
            target.minValue = m_MinValue.m_DefaultValue;
            target.maxValue = m_MaxValue.m_DefaultValue;
        }

        protected override void MobileOverride()
        {
            base.MobileOverride();

            var target = GetComponent<Slider>();
            target.minValue = m_MinValue.m_MobileValue;
            target.maxValue = m_MaxValue.m_MobileValue;
        }
    }
}
