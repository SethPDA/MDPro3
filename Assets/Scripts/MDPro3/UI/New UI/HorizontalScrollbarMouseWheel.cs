using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace MDPro3.UI
{
    [RequireComponent(typeof(ScrollRect))]
    public class HorizontalScrollbarMouseWheel : MonoBehaviour, IScrollHandler
    {
        Scrollbar scrollbar;
        public float scrollSensitivity = 0.3f;
        void Start ()
        {
            scrollbar = GetComponent<ScrollRect>().horizontalScrollbar;
        }
        public void OnScroll(PointerEventData eventData)
        {
            float scrollDelta = eventData.scrollDelta.y;
            if (scrollDelta < 0)
                scrollbar.value += scrollbar.size * scrollSensitivity;
            else if (scrollDelta > 0)
                scrollbar.value -= scrollbar.size * scrollSensitivity;
        }
    }
}
