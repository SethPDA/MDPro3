using UnityEngine;

namespace MDPro3.UI.PropertyOverrider
{
    public class PropertyOverrider_RectTransform : PropertyOverrider
    {
        [SerializeField] private OverrideProperty_Vector2 m_AnchoredPosition;
        [SerializeField] private OverrideProperty_Vector2 m_SizeDelta;

#if UNITY_EDITOR
        [SerializeField] private bool debug;
#endif

        protected override void DefaultOverride()
        {
            base.DefaultOverride();
            var target = GetComponent<RectTransform>();
#if UNITY_EDITOR
            if (debug)
            {
                Debug.LogFormat("{0}: \r\nAnchoredPosition: {1} \r\nSizeDelta: {2}", name, target.anchoredPosition, target.sizeDelta);
                debug = false;
            }
#endif
            target.anchoredPosition = m_AnchoredPosition.m_DefaultValue;
            target.sizeDelta = m_SizeDelta.m_DefaultValue;
        }

        protected override void MobileOverride()
        {
            base.MobileOverride();
            var target = GetComponent<RectTransform>();
#if UNITY_EDITOR
            if (debug)
            {
                Debug.LogFormat("{0}: \r\nAnchoredPosition: {1} \r\nSizeDelta: {2}", name, target.anchoredPosition, target.sizeDelta);
                debug = false;
            }
#endif
            target.anchoredPosition = m_AnchoredPosition.m_MobileValue;
            target.sizeDelta = m_SizeDelta.m_MobileValue;
        }

#if UNITY_EDITOR
        private void Update()
        {
            if (debug)
            {
                debug = false;
                var target = GetComponent<RectTransform>();
                Debug.LogFormat("{0}: \r\nAnchoredPosition: {1} \r\nSizeDelta: {2}", name, target.anchoredPosition, target.sizeDelta);
                debug = false;
            }
        }
#endif

    }
}
