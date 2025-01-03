using UnityEngine;
using UnityEngine.UI;

namespace MDPro3.UI.PropertyOverrider
{
    public class PropertyOverrider_Image : PropertyOverrider
    {
        [SerializeField] OverrideProperty_Sprite m_Sprite;

        protected override void DefaultOverride()
        {
            base.DefaultOverride();

            var target = GetComponent<Image>();
            target.sprite = m_Sprite.m_DefaultValue;
        }

        protected override void MobileOverride()
        {
            base.MobileOverride();

            var target = GetComponent<Image>();
            target.sprite = m_Sprite.m_MobileValue;
        }
    }
}

