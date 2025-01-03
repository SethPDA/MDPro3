using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public class HintAutoMove : MonoBehaviour, IPointerEnterHandler
    {
        bool top;
        public void OnPointerEnter(PointerEventData eventData)
        {
            if (top)
            {
                top = false;
                GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -280);
            }
            else
            {
                top = true;
                GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 280);
            }
        }
    }
}
