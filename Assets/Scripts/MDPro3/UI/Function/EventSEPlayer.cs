using UnityEngine;

namespace MDPro3.UI
{
    public class EventSEPlayer : MonoBehaviour
    {
        void PlayAnimationEventSe(string se)
        {
            AudioManager.PlaySE(se, 0.4f);
        }
        void NewEvent(string se)
        {
            AudioManager.PlaySE(se, 0.4f);
        }
    }
}
