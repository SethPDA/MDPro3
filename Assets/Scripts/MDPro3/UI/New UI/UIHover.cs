using MDPro3;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public class UIHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        public bool hover;
        public void OnPointerEnter(PointerEventData eventData)
        {
            hover = true;
            if(TryGetComponent<Image>(out var image) && UserInput.draging)
                image.color = new Color(1f, 1f, 1f, 0.2f);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            hover = false;
            if (TryGetComponent<Image>(out var image))
                image.color = Color.clear;
        }

        public void Hide()
        {
            if (TryGetComponent<Image>(out var image))
                image.color = Color.clear;
        }
    }
}
