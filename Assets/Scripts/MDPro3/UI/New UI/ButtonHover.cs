using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace MDPro3.UI
{
    public class ButtonHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        public Action hoverIn;
        public Action hoverOut;

        public void OnPointerEnter(PointerEventData eventData)
        {
            hoverIn?.Invoke();
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            hoverOut?.Invoke();

        }
    }
}
