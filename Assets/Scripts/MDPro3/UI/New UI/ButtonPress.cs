using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public class ButtonPress : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        Color imageColor;
        Color iconColor;
        Color textColor;

        public Image icon;
        public Text text;
        public float pressColor = 0.5f;

        void Awake()
        {
            imageColor = GetComponent<Image>().color;
            if (icon != null)
                iconColor = icon.color;
            if (text != null)
                textColor = text.color;
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            GetComponent<Image>().color = new Color
                (imageColor.r * pressColor * m_disableColor, imageColor.g * pressColor * m_disableColor, imageColor.b * pressColor * m_disableColor, imageColor.a);
            if (icon != null && icon.color != Color.black)
                icon.color = new Color
                    (iconColor.r * pressColor * m_disableColor, iconColor.g * pressColor * m_disableColor, iconColor.b * pressColor * m_disableColor, iconColor.a);
            if (text != null)
                text.color = new Color
                    (textColor.r * pressColor * m_disableColor, textColor.g * pressColor * m_disableColor, textColor.b * pressColor * m_disableColor, textColor.a);
        }
        public void OnPointerUp(PointerEventData eventData)
        {
            GetComponent<Image>().color = new Color
                (imageColor.r * m_disableColor, imageColor.g * m_disableColor, imageColor.b * m_disableColor, imageColor.a);
            if (icon != null && icon.color != Color.black)
                icon.color = new Color
                (iconColor.r * m_disableColor, iconColor.g * m_disableColor, iconColor.b * m_disableColor, iconColor.a);
            if (text != null)
                text.color = new Color
                (textColor.r * m_disableColor, textColor.g * m_disableColor, textColor.b * m_disableColor, textColor.a);
        }

        public float disableColor = 0.5f;
        float m_disableColor = 1f;
        public void SetInteractable(bool interactable)
        {
            var selectable = GetComponent<Selectable>();
            if (selectable == null)
                return;
            selectable.interactable = interactable;
            if (interactable)
                m_disableColor = 1f;
            else
                m_disableColor = disableColor;
            OnPointerUp(null);
        }
    }
}
