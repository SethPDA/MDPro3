using UnityEngine;

namespace MDPro3.UI.PropertyOverrider
{
    public class PropertyOverrider_GameObject : PropertyOverrider
    {
        [SerializeField] private OverrideProperty_Bool active;
        protected override void DefaultOverride()
        {
            base.MobileOverride();
            gameObject.SetActive(active.m_DefaultValue);
        }

        protected override void MobileOverride()
        {
            base.MobileOverride();
            gameObject.SetActive(active.m_MobileValue);
        }
    }
}
