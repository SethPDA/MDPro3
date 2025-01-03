using UnityEngine;
using UnityEngine.UI;

namespace MDPro3.UI.PropertyOverrider
{
    public class PropertyOverrider_RectMask2D : PropertyOverrider
    {
        [SerializeField] private OverrideProperty_Vector4 m_Padding;

        protected override void DefaultOverride()
        {
            base.DefaultOverride();

            var target = GetComponent<RectMask2D>();
            target.padding = m_Padding.m_DefaultValue;
        }

        protected override void MobileOverride()
        {
            base.MobileOverride();

            var target = GetComponent<RectMask2D>();
            target.padding = m_Padding.m_MobileValue;
        }
    }
}

