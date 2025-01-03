using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace MDPro3.UI
{
    public class ButtonSwitch : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler
    {
        bool switchOn;
        Sprite selectedSprite;
        Sprite normalSprite;
        Sprite hoverSprite;

        public GameObject onObj;
        public GameObject offObj;
        Color offColor;
        Color onColor;

        public Text text;
        public Color textOnColor = Color.black;
        public Color textOffColor = Color.white;

        public Action onAction;
        public Action offAction;

        private void Start()
        {
            normalSprite = GetComponent<Image>().sprite;
            hoverSprite = GetComponent<Button>().spriteState.highlightedSprite;
            selectedSprite = GetComponent<Button>().spriteState.selectedSprite;
            if (onObj != null)
                onObj.SetActive(false);
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            if (switchOn)
                OnSwitchOff();
            else
                OnSwitchOn();
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            GetComponent<Image>().color = new Color(0.5f, 0.5f, 0.5f, 1);
            if (onObj != null)
            {
                var imageOn = onObj.GetComponent<Image>();
                if (imageOn != null)
                {
                    onColor = imageOn.color;
                    imageOn.color = new Color(onColor.r * 0.5f, onColor.g * 0.5f, onColor.b * 0.5f, onColor.a);
                }
                var textOn = onObj.GetComponent<Text>();
                if (textOn != null)
                {
                    onColor = textOn.color;
                    textOn.color = new Color(onColor.r * 0.5f, onColor.g * 0.5f, onColor.b * 0.5f, onColor.a);
                }
            }

            if (offObj != null)
            {
                var imageOff = offObj.GetComponent<Image>();
                if (imageOff != null)
                {
                    offColor = imageOff.color;
                    imageOff.color = new Color(offColor.r * 0.5f, offColor.g * 0.5f, offColor.b * 0.5f, offColor.a);
                }
                var textOff = onObj.GetComponent<Text>();
                if (textOff != null)
                {
                    offColor = textOff.color;
                    textOff.color = new Color(offColor.r * 0.5f, offColor.g * 0.5f, offColor.b * 0.5f, offColor.a);
                }
            }
        }
        public void OnPointerUp(PointerEventData eventData)
        {
            GetComponent<Image>().color = Color.white;
            if (onObj != null)
            {
                var imageOn = onObj.GetComponent<Image>();
                if (imageOn != null)
                    imageOn.color = onColor;
                var textOn = onObj.GetComponent<Text>();
                if (textOn != null)
                    textOn.color = onColor;
            }

            if (offObj != null)
            {
                var imageOff = offObj.GetComponent<Image>();
                if (imageOff != null)
                    imageOff.color = offColor;
                var textOff = offObj.GetComponent<Text>();
                if (textOff != null)
                    textOff.color = offColor;
            }

        }
        public virtual void OnSwitchOn()
        {
            switchOn = true;
            if (onObj != null)
                onObj.SetActive(true);
            if (offObj != null)
                offObj.SetActive(false);
            GetComponent<Image>().sprite = selectedSprite;
            var state = GetComponent<Button>().spriteState;
            state.highlightedSprite = selectedSprite;
            state.pressedSprite = selectedSprite;
            GetComponent<Button>().spriteState = state;

            if (text != null)
                text.color = textOnColor;

            onAction?.Invoke();
        }
        public virtual void OnSwitchOff()
        {
            switchOn = false;
            if (onObj != null)
                onObj.SetActive(false);
            if (offObj != null)
                offObj.SetActive(true);
            GetComponent<Image>().sprite = normalSprite;
            var state = GetComponent<Button>().spriteState;
            state.highlightedSprite = hoverSprite;
            state.pressedSprite = hoverSprite;
            GetComponent<Button>().spriteState = state;

            if (text != null)
                text.color = textOffColor;

            offAction?.Invoke();
        }
    }
}
