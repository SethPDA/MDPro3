using MDPro3.Utility;
using UnityEngine;

namespace MDPro3.UI.PropertyOverrider
{
    public abstract class PropertyOverrider : MonoBehaviour
    {
        [SerializeField] protected bool decideByUser = true;

        public static bool NeedMobileLayout()
        {
            var mode = Config.GetFloat("Layout", 0f);
            if (mode == 0f)
                return DeviceInfo.OnMobile();
            else if (mode == 1f)
                return false;
            else
                return true;
        }

        protected virtual void Awake()
        {
            Override();
        }

        protected virtual void DefaultOverride()
        {
        }
        protected virtual void MobileOverride()
        {
        }


        public virtual void Override()
        {
            if (decideByUser)
            {
                if (NeedMobileLayout())
                    MobileOverride();
                else
                    DefaultOverride();
            }
            else
            {
                if (DeviceInfo.OnMobile())
                    MobileOverride();
                else
                    DefaultOverride();
            }
        }
    }
}
