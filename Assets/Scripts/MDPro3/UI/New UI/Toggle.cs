using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public class Toggle : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler
    {
        Sprite normalSprite;
        Sprite hoverSprite;
        Sprite normalSprite2;
        Sprite hoverSprite2;

        public bool switchOn;
        public Text label;
        public Image icon;
        Color normalColor;
        Color labelOffColor;
        public Color labelOnColor;
        Color iconOffColor;
        public Color iconOnColor;
        public float pressColor = 0.5f;
        void Awake()
        {
            var button = GetComponent<Button>();
            normalSprite = GetComponent<Image>().sprite;
            hoverSprite = button.spriteState.highlightedSprite;
            normalSprite2 = button.spriteState.selectedSprite;
            hoverSprite2 = button.spriteState.disabledSprite;
            if (label != null)
                labelOffColor = label.color;
            if (icon != null)
                iconOffColor = icon.color;
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            if (switchOn)
                OnClickOff();
            else
                OnClickOn();
        }

        public virtual void OnClickOn()
        {
            AudioManager.PlaySE("SE_MENU_S_DECIDE_01");
            SwitchOn();
        }
        public virtual void OnClickOff()
        {
            AudioManager.PlaySE("SE_MENU_S_DECIDE_02");
            SwitchOff();
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            GetComponent<Image>().color = new Color(pressColor, pressColor, pressColor, 1);
            if (label != null)
            {
                normalColor = label.color;
                label.color = new Color(normalColor.r * pressColor, normalColor.g * pressColor, normalColor.b * pressColor, 1);
            }
            if (icon != null)
            {
                normalColor = icon.color;
                icon.color = new Color(normalColor.r * pressColor, normalColor.g * pressColor, normalColor.b * pressColor, 1);
            }
        }
        public void OnPointerUp(PointerEventData eventData)
        {
            GetComponent<Image>().color = Color.white;
            if (label != null)
                label.color = normalColor;
            if (icon != null)
                icon.color = normalColor;
        }

        public virtual void SwitchOn()
        {
            SwitchOnWithoutAction();
        }
        public void SwitchOnWithoutAction()
        {
            switchOn = true;
            if (normalSprite == null)
                Awake();
            var state = GetComponent<Button>().spriteState;
            GetComponent<Image>().sprite = normalSprite2;
            state.highlightedSprite = hoverSprite2;
            state.pressedSprite = hoverSprite2;
            GetComponent<Button>().spriteState = state;
            if (label != null)
                label.color = labelOnColor;
            if (icon != null)
                icon.color = iconOnColor;
        }
        public virtual void SwitchOff()
        {
            SwitchOffWithoutAction();
        }
        public void SwitchOffWithoutAction()
        {
            switchOn = false;
            if(normalSprite == null)
                Awake();
            var state = GetComponent<Button>().spriteState;
            GetComponent<Image>().sprite = normalSprite;
            state.highlightedSprite = hoverSprite;
            state.pressedSprite = hoverSprite;
            GetComponent<Button>().spriteState = state;
            if (label != null)
                label.color = labelOffColor;
            if (icon != null)
                icon.color = iconOffColor;
        }
    }
}
