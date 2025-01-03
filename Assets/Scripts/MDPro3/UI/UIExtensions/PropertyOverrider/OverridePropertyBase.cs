using System;

namespace MDPro3.UI.PropertyOverrider
{
    [Serializable]
    public class OverridePropertyBase<T>
    {
        public T m_DefaultValue;

        public T m_MobileValue;

        public T GetPlatformValue(bool mobile)
        {
            if (mobile)
                return m_MobileValue;
            else
                return m_DefaultValue;
        }

        public void SetPlatformValue(bool mobile, T value)
        {
            if(mobile)
                m_MobileValue = value;
            else
                m_DefaultValue = value;
        }
    }
}
